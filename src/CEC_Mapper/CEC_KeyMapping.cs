using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Mapper
{
    public class CEC_KeyMapping
    {
        private String _processName = String.Empty;
        private int _processId = -1;

        private Dictionary<int, CEC_KeyboardKey> _keyMappingList = new Dictionary<int, CEC_KeyboardKey>();

        private Dictionary<billy_boy.CEC_Mapper.CEC_Enums.CEC_Event, CEC_KeyboardKey> _eventMappingList = new Dictionary<billy_boy.CEC_Mapper.CEC_Enums.CEC_Event, CEC_KeyboardKey>();

        public CEC_KeyMapping(int processId)
        {
            _processId = processId;
        }

        public CEC_KeyMapping(String processName)
        {
            _processName = processName;
        }

        public void AddMapping(int cec_key, CEC_KeyboardKey keyboard_key)
        {
            _keyMappingList.Add(cec_key,keyboard_key);
        }

        public void AddMapping(billy_boy.CEC_Mapper.CEC_Enums.CEC_Event cec_event, CEC_KeyboardKey keyboard_key)
        {
            _eventMappingList.Add(cec_event, keyboard_key);
        }

        public void ClearMappings()
        {
            _keyMappingList.Clear();
            _eventMappingList.Clear();
        }

        public CEC_KeyboardKey getMapping(int cec_key)
        {
            return _keyMappingList[cec_key];
        }

        public bool hasMapping(int cec_key)
        {
            return _keyMappingList.ContainsKey(cec_key);
        }

        public CEC_KeyboardKey getEventMapping(billy_boy.CEC_Mapper.CEC_Enums.CEC_Event cec_event)
        {
            return _eventMappingList[cec_event];
        }

        public bool hasEventMapping(billy_boy.CEC_Mapper.CEC_Enums.CEC_Event cec_event)
        {
            return _eventMappingList.ContainsKey(cec_event);
        }

        public String ProcessName { get { return _processName; } }
        public int ProcessId { get { return _processId; } }

    }
}
