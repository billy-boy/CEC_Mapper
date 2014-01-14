using System;
using System.Collections.Generic;
using System.Text;

namespace billy_boy.CEC_Receiver
{
    public class CEC_Adapter
    {
        String _path;
        String _comPort;

        public CEC_Adapter(String path, String comPort)
        {
            _path = path;
            _comPort = comPort;
        }

        public String Path { get { return _path; } }
        public String ComPort { get { return _comPort; } }
    }
}
