using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace billy_boy.CEC_Objects
{
    public class CEC_EventMap
    {
        private billy_boy.CEC_Objects.CEC_Enums.CEC_Event _cec_event = 0;
        private CEC_KeyboardKey _keyboard_key = null;

        public CEC_EventMap(billy_boy.CEC_Objects.CEC_Enums.CEC_Event cec_event, CEC_KeyboardKey keyboard_key)
        {
            _cec_event = cec_event;
            _keyboard_key = keyboard_key;
        }

        public billy_boy.CEC_Objects.CEC_Enums.CEC_Event CEC_Event { get { return _cec_event; } }
        public CEC_KeyboardKey Keyboard_Key { get { return _keyboard_key; } }
    }
}
