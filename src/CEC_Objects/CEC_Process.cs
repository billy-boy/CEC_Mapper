using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Objects
{
    public class CEC_Process
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private String _processName = String.Empty;
        private int _processId = -1;

        private CEC_KeyMapList _keyMappingList = new CEC_KeyMapList();

        private CEC_EventMapList _eventMappingList = new CEC_EventMapList();

        public CEC_Process(int processId)
        {
            _processId = processId;
        }

        public CEC_Process(String processName)
        {
            _processName = processName;
        }

        public void AddMapping(int cec_key, CEC_KeyboardKey keyboard_key)
        {
            _keyMappingList.Add(new CEC_KeyMap(cec_key,keyboard_key));
        }

        public void AddMapping(billy_boy.CEC_Objects.CEC_Enums.CEC_Event cec_event, CEC_KeyboardKey keyboard_key)
        {
            _eventMappingList.Add(new CEC_EventMap(cec_event, keyboard_key));
        }

        public void ClearMappings()
        {
            _keyMappingList.Clear();
            _eventMappingList.Clear();
        }

        public CEC_KeyMap getMapping(int cec_key)
        {
            return _keyMappingList[cec_key];
        }

        public bool hasMapping(int cec_key)
        {
            return _keyMappingList.Contains(cec_key);
        }

        public CEC_EventMap getEventMapping(billy_boy.CEC_Objects.CEC_Enums.CEC_Event cec_event)
        {
            return _eventMappingList[cec_event];
        }

        public bool hasEventMapping(billy_boy.CEC_Objects.CEC_Enums.CEC_Event cec_event)
        {
            return _eventMappingList.Contains(cec_event);
        }
                
        public void Save(String folder)
        {
            if (Directory.Exists(folder))
            {
                if (!File.Exists(Path.Combine(folder, _processName + ".cfg")))
                {
                    File.WriteAllText(Path.Combine(folder, _processName + ".cfg"), this.ToString());
                    if (log.IsDebugEnabled) log.Debug("Process saved to new file '" + Path.Combine(folder, _processName + ".cfg") + "'.");
                }
                else
                {
                    File.WriteAllText(Path.Combine(folder, _processName + ".cfg"), this.ToString());
                    if (log.IsDebugEnabled) log.Debug("Process saved to existing file '" + Path.Combine(folder, _processName + ".cfg") + "'.");
                }
            }
        }

        public void Delete(String folder)
        {
            if (Directory.Exists(folder))
            {
                if (File.Exists(Path.Combine(folder, _processName.ToLower() + ".cfg")))
                {
                    File.Delete(Path.Combine(folder, _processName.ToLower() + ".cfg"));
                    if (log.IsDebugEnabled) log.Debug("The file '" + Path.Combine(folder, _processName.ToLower() + ".cfg") + "' has been deleted.");
                }
            }
        }

        public String ProcessName { get { return _processName; } }
        public int ProcessId { get { return _processId; } }
        public CEC_KeyMapList KeyMappList { get { return _keyMappingList; } }
        public CEC_EventMapList EventMappList { get { return _eventMappingList; } }

        public override String ToString()
        {
            String ret = "";
            ret += "[Process]\r\nName=" + _processName+"\r\n";
            ret += "[KeyMap_KeyPress]\r\n";
            foreach (CEC_KeyMap map in _keyMappingList)
            {
                ret += map.CEC_Key.ToString() + "=";
                if (map.Keyboard_Key.Type == CEC_KeyboardKey.CEC_KeyboardKey_Type.Key)
                {
                    ret += (int)map.Keyboard_Key.Keys + (((map.Keyboard_Key.Keys & Keys.Shift) == Keys.Shift) ? ",Shift" : "") + (((map.Keyboard_Key.Keys & Keys.Alt) == Keys.Alt) ? ",Alt" : "") + (((map.Keyboard_Key.Keys & Keys.Control) == Keys.Control) ? ",Control" : "") + "\r\n";
                }
                else
                {
                    ret += "MAKRO:" + map.Keyboard_Key.Makro.FileName + "," + map.Keyboard_Key.Makro.Arguments + "," + map.Keyboard_Key.Makro.CreateNoWindow.ToString() + "," + map.Keyboard_Key.Makro.WindowStyle.ToString() + "\r\n";
                }
            }
            ret += "[KeyMap_Events]\r\n";
            foreach (CEC_EventMap map in _eventMappingList)
            {
                ret += map.CEC_Event.ToString() + "=";
                if (map.Keyboard_Key.Type == CEC_KeyboardKey.CEC_KeyboardKey_Type.Key)
                {
                    ret += (int)map.Keyboard_Key.Keys + (((map.Keyboard_Key.Keys & Keys.Shift) == Keys.Shift) ? ",Shift" : "") + (((map.Keyboard_Key.Keys & Keys.Alt) == Keys.Alt) ? ",Alt" : "") + (((map.Keyboard_Key.Keys & Keys.Control) == Keys.Control) ? ",Control" : "") + "\r\n";
                }
                else
                {
                    ret += "MAKRO:" + map.Keyboard_Key.Makro.FileName + "," + map.Keyboard_Key.Makro.Arguments + "," + map.Keyboard_Key.Makro.CreateNoWindow.ToString() + "," + map.Keyboard_Key.Makro.WindowStyle.ToString() + "\r\n";
                }
            }
            return ret;
        }
    }
}
