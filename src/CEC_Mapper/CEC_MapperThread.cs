using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace billy_boy.CEC_Mapper
{
    public class CEC_MapperThread
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Singleton

        private static CEC_MapperThread _instance = null;

        public static CEC_MapperThread getInstance()
        {
            if (_instance == null) _instance = new CEC_MapperThread();
            return _instance;
        }

        #endregion

        private CEC_Mapper _mapper = null;
        private Thread _mapperThread = null;

        public CEC_MapperThread()
        {
            //Start();
        }

        ~CEC_MapperThread()
        {
            Stop();
        }

        public void Restart()
        {
            StartStopWorker();
        }

        public void Start()
        {
            if (_mapperThread == null || !_mapperThread.IsAlive)
            {
                StartStopWorker();
            }
        }

        public void Stop()
        {
            while (_mapperThread != null && _mapperThread.IsAlive) { _mapper.RequestStop(); }
            _mapper = null;
            if (log.IsDebugEnabled) log.Debug("Stopped the mapper thread.");
        }

        private void StartStopWorker()
        {
            if (_mapperThread != null)
            {
                while (_mapperThread.IsAlive)
                    _mapper.RequestStop();
                _mapperThread = null;
            }
            _mapper = new CEC_Mapper();
            _mapperThread = new Thread(_mapper.DoWork);
            _mapperThread.Start();
            if (log.IsDebugEnabled) log.Debug("Started the mapper thread.");
        }

        public bool Running { get { return (_mapperThread != null && _mapperThread.IsAlive); } }
        public Int32 ThreadId { get { if (_mapperThread != null) return _mapperThread.ManagedThreadId; return 0; } }
        public CEC_Mapper Mapper { get { if (_mapper != null) return _mapper; return null; } }

    }
}
