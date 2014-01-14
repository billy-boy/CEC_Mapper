using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Mapper
{
    public class CEC_KeyboardKey
    {
        public enum CEC_KeyboardKey_Type { Key, Makro }

        private CEC_KeyboardKey_Type _type = CEC_KeyboardKey_Type.Key;

        private ProcessStartInfo _makro = null;

        private Keys _keys = Keys.None;

        public CEC_KeyboardKey(Keys keys)
        {
            _type = CEC_KeyboardKey_Type.Key;
            _keys = keys;
        }

        public CEC_KeyboardKey(ProcessStartInfo makro)
        {
            _type = CEC_KeyboardKey_Type.Makro;
            _makro = makro;
        }

        public CEC_KeyboardKey_Type Type { get { return _type; } }
        public Keys Keys { get { return _keys; } }
        public ProcessStartInfo Makro { get { return _makro; } }
    }
}
