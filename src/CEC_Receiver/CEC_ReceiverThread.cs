using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace billy_boy.CEC_Receiver
{
    public class CEC_ReceiverThread
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private volatile bool _shouldStop = false;
        private bool _connected = false;

        private CEC_Receiver _receiver = null;

        public CEC_ReceiverThread()
        {
            Init();
        }

        private void Init()
        {
            if (log.IsDebugEnabled) log.Debug("receiver thread: inititalising...");
            _receiver = new CEC_Receiver();
            _receiver.OnKeyPress += ReceiverOnKeyPress;
            _receiver.OnSourceActivated += ReceiverOnSourceActivated;
            _receiver.OnStandby += ReceiverOnStandby;
            if (_receiver.Start())
            {
                if (log.IsDebugEnabled) log.Debug("receiver thread: started CEC receiver.");
            }
            else
                if (log.IsErrorEnabled) log.Error("receiver thread: could not startup CEC receiver.");
        }

        #region Receiver event handling

        private void ReceiverOnStandby(object sender, CEC_StandbyEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("CEC receiver raised standby event: device: ["+e.Device.ToString()+"]");

            //Raise an own event
            if (OnStandby != null)
            {
                OnStandby(this, new CEC_StandbyEventArgs { Device = e.Device });
            }
        }

        private void ReceiverOnSourceActivated(object sender, CEC_SourceActivatedEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("CEC receiver raised source activated event: Status: [has been " + (e.Activated ? "activated" : "deactivated")+"]");

            //Raise an own event
            if (OnSourceActivated != null)
            {
                OnSourceActivated(this, new CEC_SourceActivatedEventArgs { Activated = e.Activated });
            }
        }

        private void ReceiverOnKeyPress(object sender, CEC_KeyPressEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info(String.Format("CEC receiver raised key press event: KeyCode: [{0}]", e.KeyCode.ToString()));

            //Raise an own event
            if (OnKeyPress != null)
            {
                OnKeyPress(this, new CEC_KeyPressEventArgs { KeyCode = e.KeyCode, KeyDown = e.KeyDown });
            }
        }

        #endregion

        ~CEC_ReceiverThread()
        {
            Stop();
        }

        public void RequestStop()
        {
            if (log.IsDebugEnabled) log.Debug("Stopping of this thread requested.");
            _shouldStop = true;
        }

        public void DoWork()
        {
            while (!_shouldStop)
            {
                //if (log.IsDebugEnabled) log.Debug("worker thread: working...");
                try
                {
                    CheckAlive();
                }
                catch (Exception ex)
                {
                    if (log.IsErrorEnabled) log.Error("Error in receiver thread's check alive: "+ex.Message);
                }
                Thread.Sleep(5000);
            }
            Stop();
            if (log.IsDebugEnabled) log.Debug("receiver thread terminated gracefully.");
        }

        private void CheckAlive()
        {
            //Check connection to adapter
            while (!_shouldStop && (!_receiver.Connected || !_receiver.Ping()))
            {
                _connected = false;
                if (log.IsWarnEnabled) log.Warn("receiver thread: receiver lost connection to adapter. Try to restart.");
                _receiver.Start();
                Thread.Sleep(CEC_Config.ConnectionTimeout);
            }
            _connected = true;
        }

        private void Stop()
        {
            if (_receiver != null)
            {
                _receiver.Stop();
            }
            _connected = false;
            _receiver = null;
            if (log.IsDebugEnabled) log.Debug("Stoped the receiver thread.");
        }

        public bool Connected { get { return _connected;  } }
        public String Adpater_Port { get { if (_receiver != null) return _receiver.Port; return ""; } }
        public CEC_Receiver Receiver { get { return _receiver; } }

        #region Backward event handler

        public event KeyPressEventHandler OnKeyPress = null;
        public delegate void KeyPressEventHandler(object sender, CEC_KeyPressEventArgs e);

        public event StandbyEventHandler OnStandby = null;
        public delegate void StandbyEventHandler(object sender, CEC_StandbyEventArgs e);

        public event SourceActivatedEventHandler OnSourceActivated = null;
        public delegate void SourceActivatedEventHandler(object sender, CEC_SourceActivatedEventArgs e);

        #endregion
    }
}
