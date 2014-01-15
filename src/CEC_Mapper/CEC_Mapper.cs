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

        private CEC_Worker _worker = null;
        private Thread _workerThread = null;
        
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
        }

        private void StartStopWorker()
        {
            if (_workerThread != null)
            {
                while (_workerThread.IsAlive)
                    _worker.RequestStop();
                _workerThread = null;
            }
            _worker = new CEC_Worker();
            _worker.OnKeyPress += WorkerOnKeyPress;
            _worker.OnSourceActivated += WorkerOnSourceActivated;
            _workerThread = new Thread(_worker.DoWork);
            _workerThread.Start();
            if (log.IsDebugEnabled) log.Debug("Started the worker thread.");
        }

        public void RequestStop()
        {
            if (log.IsDebugEnabled) log.Debug("Stopping of this thread requested.");
            _shouldStop = true;
        }

        public void DoWork()
        {
            Init();
            StartStopWorker();
            while (!_shouldStop)
            {
                //if (log.IsDebugEnabled) log.Debug("worker thread: working...");
            }
            Stop();
            if (log.IsDebugEnabled) log.Debug("mapper thread terminated gracefully.");
        }

        public void Restart()
        {
            StartStopWorker();
        }

        public void Start()
        {
            if (_workerThread == null || !_workerThread.IsAlive)
            {
                StartStopWorker();
            }
        }

        public void Stop()
        {
            while (_workerThread != null && _workerThread.IsAlive) { _worker.RequestStop(); }
            _worker = null;
            if (log.IsDebugEnabled) log.Debug("Stoped the mapper thread.");

        }

        void WorkerOnSourceActivated(object sender, CEC_SourceActivatedEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("Source state changed: [" + (e.Activated ? "activated" : "deactivated") + "]");
        }

        void WorkerOnKeyPress(object sender, CEC_KeyPressEventArgs e)
        {
            if (log.IsInfoEnabled) log.Info("HDMI CEC key pressed: [" + e.KeyCode.ToString() + "]");
            CEC_KeySender.SendMapingKey(e.KeyCode);
        }

        public bool Running { get { return (_workerThread != null && _workerThread.IsAlive); } }
        public Int32 ThreadId { get { if (_workerThread != null) return _workerThread.ManagedThreadId; return 0; } }
        public CEC_Worker Worker { get { if (_worker != null) return _worker; return null; } }
    }
}
