using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace billy_boy.CEC_Receiver
{
    public class CEC_Worker
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private volatile bool _shouldStop = false;

        private CEC_Receiver _receiver = null;

        public CEC_Worker()
        {
            if (log.IsDebugEnabled) log.Debug("worker thread: inititalising...");
            _receiver = new CEC_Receiver();
            _receiver.OnKeyPress += ReceiverOnKeyPress;
            _receiver.OnSourceActivated += ReceiverOnSourceActivated;
            if (_receiver.Start())
            {
                if (log.IsDebugEnabled) log.Debug("worker thread: started CEC receiver.");
            }
            else
                if (log.IsErrorEnabled) log.Error("worker thread: could not startup CEC receiver.");
        }

        #region Receiver event handling

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
                OnKeyPress(this, new CEC_KeyPressEventArgs { KeyCode = e.KeyCode });
            }
        }

        #endregion

        ~CEC_Worker()
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
                CheckAlive();
                Thread.Sleep(5000);
            }
            Stop();
            if (log.IsDebugEnabled) log.Debug("worker thread terminated gracefully.");
        }

        private void CheckAlive()
        {
            //Check connection to adapter
            while (!_receiver.Connected || !_receiver.Ping())
            {
                if (log.IsWarnEnabled) log.Warn("worker thread: receiver lost connection to adapter. Try to restart.");
                _receiver.Start();
                Thread.Sleep(CEC_Config.ConnectionTimeout);
            }
        }

        private void Stop()
        {
            if (_receiver != null)
            {
                _receiver.Stop();
            }
            _receiver = null;
            if (log.IsDebugEnabled) log.Debug("Stoped the worker thread.");
        }

        #region Backward event handler

        public event KeyPressEventHandler OnKeyPress = null;
        public delegate void KeyPressEventHandler(object sender, CEC_KeyPressEventArgs e);

        public event SourceActivatedEventHandler OnSourceActivated = null;
        public delegate void SourceActivatedEventHandler(object sender, CEC_SourceActivatedEventArgs e);

        #endregion
    }
}
