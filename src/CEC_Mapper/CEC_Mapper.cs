using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using billy_boy.CEC_Receiver;
using billy_boy.CEC_Objects;

namespace billy_boy.CEC_Mapper
{
    public class CEC_Mapper
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private volatile bool _shouldStop = false;

        private CEC_ReceiverThread _receiver = null;
        private Thread _receiverThread = null;
        
        public CEC_Mapper()
        {
            //Init();
        }

        ~CEC_Mapper()
        {
            Stop();
        }

        private void Init()
        {
            if (log.IsDebugEnabled) log.Debug("Initialising the config.");
            CEC_ProcessList.getInstance().importKeyMaps(System.AppDomain.CurrentDomain.BaseDirectory + @"\mapping");
            CEC_Receiver.CEC_Config.importConfig(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,@"config.cfg"));
            CEC_Config.importConfig(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"mapper.cfg"));
        }

        public void ReInit()
        {
            Init();
        }

        private void StartStopWorker()
        {
            if (_receiverThread != null)
            {
                while (_receiverThread.IsAlive)
                    _receiver.RequestStop();
                _receiverThread = null;
            }
            _receiver = new CEC_ReceiverThread();
            _receiver.OnKeyPress += WorkerOnKeyPress;
            _receiver.OnSourceActivated += WorkerOnSourceActivated;
            _receiver.OnStandby += WorkerOnStandby;
            _receiverThread = new Thread(_receiver.DoWork);
            _receiverThread.Start();
            if (log.IsDebugEnabled) log.Debug("Started the worker thread.");
        }

        public void RequestStop()
        {
            if (log.IsDebugEnabled) log.Debug("Stopping of this thread requested.");
            _shouldStop = true;
        }

        public void DoWork()
        {
            try
            {
                Init();
                StartStopWorker();
                while (!_shouldStop)
                {
                    //if (log.IsDebugEnabled) log.Debug("worker thread: working...");
                }
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled) log.Error("Could not start receiver thread: " + ex.Message);
            }
            if (_shouldStop)
            {
                if (log.IsDebugEnabled) log.Debug("mapper thread terminated gracefully.");
                Stop();
            }
            else
            {
                if (log.IsDebugEnabled) log.Debug("mapper thread terminated due to error. Rerunning.");
                DoWork();
            }
        }

        public void Restart()
        {
            StartStopWorker();
        }

        public void Start()
        {
            if (_receiverThread == null || !_receiverThread.IsAlive)
            {
                StartStopWorker();
            }
        }

        public void Stop()
        {
            while (_receiverThread != null && _receiverThread.IsAlive) { _receiver.RequestStop(); }
            _receiver = null;
            if (log.IsDebugEnabled) log.Debug("Stoped the mapper thread.");

        }

        void WorkerOnSourceActivated(object sender, CEC_SourceActivatedEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("HDMI CEC source state changed: [" + (e.Activated ? "activated" : "deactivated") + "]");
        }
        
        void WorkerOnStandby(object sender, CEC_StandbyEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("HDMI CEC standby raised: device: [" + e.Device.ToString() + "]");
        }

        void WorkerOnKeyPress(object sender, CEC_KeyPressEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("HDMI CEC key pressed: [" + e.KeyCode.ToString() + "] key pressed type: ["+(e.KeyDown ? "down" : "up")+"]");
            try
            {
                CEC_KeySender.SendMapingKey(e);
            }
            catch (Exception ex)
            {
                if (log.IsErrorEnabled) log.Error("Error while sending key from mapper thread: " + ex.Message);
            }
        }

        public bool Running { get { return (_receiverThread != null && _receiverThread.IsAlive); } }
        public Int32 ThreadId { get { if (_receiverThread != null) return _receiverThread.ManagedThreadId; return 0; } }
        public CEC_ReceiverThread Worker { get { if (_receiver != null) return _receiver; return null; } }
    }
}
