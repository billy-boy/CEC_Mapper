using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace billy_boy.CEC_Objects
{
    public class CEC_KeyMap
    {
        private int _cec_key = 0;
        private CEC_KeyboardKey _keyboard_key = null;

        public CEC_KeyMap(int cec_key, CEC_KeyboardKey keyboard_key)
        {
            _cec_key = cec_key;
            _keyboard_key = keyboard_key;
        }

        public int CEC_Key { get { return _cec_key; } }
        public CEC_KeyboardKey Keyboard_Key { get { return _keyboard_key; } }
    }
}
