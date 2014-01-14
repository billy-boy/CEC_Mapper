using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Objects
{
    public class CEC_ProcessList : System.Collections.CollectionBase
    {
        #region Singleton

        private static CEC_ProcessList _instance = null;

        public static CEC_ProcessList getInstance()
        {
            if (_instance == null) _instance = new CEC_ProcessList();
            return _instance;
        }

        #endregion

        public CEC_ProcessList()
		{
		}

        public void Add(CEC_Process item)
		{
            if (!base.InnerList.Contains(item))
                base.InnerList.Add(item);
		}

        public void Remove(CEC_Process item)
        {
            base.InnerList.Remove(item);
        }

        public bool Contains(CEC_Process item)
        {
            foreach (CEC_Process s in base.InnerList)
            {
                if (s == item)
                    return true;
            }
            return false;
        }

        public bool Contains(String processName)
        {
            foreach (CEC_Process s in base.InnerList)
            {
                if (s.ProcessName == processName)
                    return true;
            }
            return false;
        }

        public CEC_Process this[int index]
		{
			get
			{
                return (CEC_Process)base.InnerList[index];

			}
		}

        public CEC_Process this[String processName]
        {
            get
            {
                foreach (CEC_Process s in base.InnerList)
                {
                    if (s.ProcessName == processName)
                        return s;
                }
                return null;
            }
        }

        private void importEntry(ref CEC_Process mapping, String section, String name, String value)
        {
            if (mapping == null)
                return;

            if (section == "KeyMap_KeyPress")
            {
                int cec_key= -1;
                if (!Int32.TryParse(name.Trim(), out cec_key))
                    return;
                String[] spl = value.Split(',');
                if (value.StartsWith("MAKRO:"))
                {
                    String makroApp = spl[0].Substring(6).Trim();
                    String makroArgs = String.Empty;
                    bool makroNoWindow = false;
                    ProcessWindowStyle makroStyle = ProcessWindowStyle.Normal;
                    if (spl.Length > 1)
                        makroArgs = spl[1].Trim();
                    if (spl.Length > 2)
                        Boolean.TryParse(spl[2].Trim(), out makroNoWindow);
                    if (spl.Length > 3) { Int32 style; if (Int32.TryParse(spl[3].Trim(), out style)) { makroStyle = (ProcessWindowStyle)style; } }
                    ProcessStartInfo makro = new ProcessStartInfo();
                    makro.FileName = makroApp;
                    makro.Arguments = makroArgs;
                    makro.CreateNoWindow = makroNoWindow;
                    makro.WindowStyle = makroStyle;
                    mapping.AddMapping(cec_key, new CEC_KeyboardKey(makro));
                }
                else
                {                  
                    byte keycode;
                    if (!Byte.TryParse(spl[0].Trim(), out keycode))
                        return;
                    Keys keyboard_keys = (Keys)keycode;
                    for (int i = 1; i < spl.Length - 1; i++)
                    {
                        if (spl[i].Trim().ToLower() == "shift")
                            keyboard_keys = keyboard_keys | Keys.Shift;
                        else if (spl[i].Trim().ToLower() == "alt")
                            keyboard_keys = keyboard_keys | Keys.Alt;
                        else if (spl[i].Trim().ToLower() == "control")
                            keyboard_keys = keyboard_keys | Keys.Control;
                    }
                    if (cec_key != -1)
                        mapping.AddMapping(cec_key, new CEC_KeyboardKey(keyboard_keys));
                }
            }
            else if (section == "KeyMap_Events")
            {
                CEC_Enums.CEC_Event cec_event = CEC_Enums.CEC_Event.None;
                if (name.Trim() == "SourceActivated")
                    cec_event = CEC_Enums.CEC_Event.Local_Source_Activated;
                else if (name.Trim() == "SourceDeactivated")
                    cec_event = CEC_Enums.CEC_Event.Local_Source_Deactivated;
                String[] spl = value.Split(',');
                if (value.StartsWith("MAKRO:"))
                {
                    String makroApp = spl[0].Substring(6).Trim();
                    String makroArgs = String.Empty;
                    bool makroNoWindow = false;
                    ProcessWindowStyle makroStyle = ProcessWindowStyle.Normal;
                    if (spl.Length > 1)
                        makroArgs = spl[1].Trim();
                    if (spl.Length > 2)
                        Boolean.TryParse(spl[2].Trim(), out makroNoWindow);
                    if (spl.Length > 3) { Int32 style; if (Int32.TryParse(spl[3].Trim(), out style)) { makroStyle = (ProcessWindowStyle)style; } }
                    ProcessStartInfo makro = new ProcessStartInfo();
                    makro.FileName = makroApp;
                    makro.Arguments = makroArgs;
                    makro.CreateNoWindow = makroNoWindow;
                    makro.WindowStyle = makroStyle;
                    mapping.AddMapping(cec_event, new CEC_KeyboardKey(makro));
                }
                else
                {                
                    byte keycode;
                    if (!Byte.TryParse(spl[0].Trim(), out keycode))
                        return;
                    Keys keyboard_keys = (Keys)keycode;
                    for (int i = 1; i < spl.Length - 1; i++)
                    {
                        if (spl[i].Trim().ToLower() == "shift")
                            keyboard_keys = keyboard_keys | Keys.Shift;
                        else if (spl[i].Trim().ToLower() == "alt")
                            keyboard_keys = keyboard_keys | Keys.Alt;
                        else if (spl[i].Trim().ToLower() == "control")
                            keyboard_keys = keyboard_keys | Keys.Control;
                    }
                    if (cec_event != CEC_Enums.CEC_Event.None)
                        mapping.AddMapping(cec_event, new CEC_KeyboardKey(keyboard_keys));
                }
            }
        }

        public void importKeyMap(String fileName)
        {
            if (!File.Exists(fileName))
                return;
            
            StreamReader str = new StreamReader(fileName);
            String line;
            String section = String.Empty;
            CEC_Process mapping = null;
            while ((line = str.ReadLine()) != null)
            {
                //Section
                if (!line.Contains("=") && line.StartsWith("["))
                {
                    section = line.Replace("[", "").Replace("]", "").Trim();
                }
                //Token=Value
                else if (line.Contains("="))
                {
                    String[] spl = line.Split('=');
                    if (spl.Length > 1)
                    {
                        if (section == "Process" && spl[0].Trim() == "Name")
                        {
                            mapping = this[spl[1].Trim()];
                            if (mapping == null) mapping = new CEC_Process(spl[1].Trim());
                            mapping.ClearMappings();
                        }
                        else
                            importEntry(ref mapping, section, spl[0], spl[1]);
                    }
                }
            }
            base.InnerList.Add(mapping);
            str.Close();
        }

        public void importKeyMaps(String folder)
        {
             base.InnerList.Clear();

             if (Directory.Exists(folder))
             {
                 DirectoryInfo dir = new DirectoryInfo(folder);
                 foreach (FileInfo file in dir.GetFiles())
                 {
                     if (file.FullName.EndsWith(".cfg"))
                     {
                         importKeyMap(file.FullName);
                     }
                 }
             }
        }
    }
}
