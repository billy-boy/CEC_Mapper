using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Objects
{
    public class CEC_KeyboardKey
    {
        private CEC_Enums.CEC_KeyboardKey_Type _type = CEC_Enums.CEC_KeyboardKey_Type.Key;
        private ProcessStartInfo _makro = null;
        private Keys _keys = Keys.None;
        private CEC_Enums.CEC_KeyPressMode _keyPressMode = CEC_Enums.CEC_KeyPressMode.KeyPress;

        public CEC_KeyboardKey(Keys keys, CEC_Enums.CEC_KeyPressMode keyPressMode)
        {
            _type = CEC_Enums.CEC_KeyboardKey_Type.Key;
            _keys = keys;
            _keyPressMode = keyPressMode;
        }
        public CEC_KeyboardKey(ProcessStartInfo makro)
        {
            _type = CEC_Enums.CEC_KeyboardKey_Type.Makro;
            _makro = makro;
        }

        public CEC_Enums.CEC_KeyboardKey_Type Type { get { return _type; } }
        public CEC_Enums.CEC_KeyPressMode KeyPressMode { get { return _keyPressMode; } }
        public Keys Keys { get { return _keys; } }
        public ProcessStartInfo Makro { get { return _makro; } }
    }
}
