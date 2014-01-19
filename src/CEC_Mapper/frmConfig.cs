using billy_boy.CEC_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Mapper
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
            Init();
            InitListViews();
        }

        private void Init()
        {
            _txtConnectionTimeout.Text = CEC_Receiver.CEC_Config.ConnectionTimeout.ToString();
            _txtDeviceName.Text = CEC_Receiver.CEC_Config.DeviceName;
            _txtHDMI_Port.Text = CEC_Receiver.CEC_Config.HDMI_Port.ToString();


            _cmbDeviceType.Items.Clear();
            foreach (CecSharp.CecDeviceType deviceType in Enum.GetValues(typeof(CecSharp.CecDeviceType)))
            {
                int index = _cmbDeviceType.Items.Add(deviceType);
                if (deviceType == CEC_Receiver.CEC_Config.DeviceType)
                    _cmbDeviceType.SelectedIndex = index;
            }

            _cmbLogLevel.Items.Clear();
            foreach (CecSharp.CecLogLevel logLevel in Enum.GetValues(typeof(CecSharp.CecLogLevel)))
            {
                int index = _cmbLogLevel.Items.Add(logLevel);
                if (logLevel == CEC_Receiver.CEC_Config.CEC_LogLevel)
                    _cmbLogLevel.SelectedIndex = index;
            }

            _cmbVendorId.Items.Clear();
            foreach (CecSharp.CecVendorId vendorId in Enum.GetValues(typeof(CecSharp.CecVendorId)))
            {
                int index = _cmbVendorId.Items.Add(vendorId);
                if (vendorId == CEC_Receiver.CEC_Config.CEC_Vendor)
                    _cmbVendorId.SelectedIndex = index;
            }

            _cmbBaseDevice.Items.Clear();
            foreach (CecSharp.CecLogicalAddress logicalAddress in Enum.GetValues(typeof(CecSharp.CecLogicalAddress)))
            {
                int index = _cmbBaseDevice.Items.Add(logicalAddress);
                if (logicalAddress == CEC_Receiver.CEC_Config.CEC_BaseDevice)
                    _cmbBaseDevice.SelectedIndex = index;
            }

        }

        private void Safe()
        {
            Int32 connectionTimeout = 0;
            if (!Int32.TryParse(_txtConnectionTimeout.Text, out connectionTimeout))
                MessageBox.Show(this, "The entered value for the connection timeout is not a valid number. Please enter only digits.", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                CEC_Receiver.CEC_Config.ConnectionTimeout = connectionTimeout;
            
            CEC_Receiver.CEC_Config.DeviceName = _txtDeviceName.Text;

            byte hdmiPort = 0;
            if (!Byte.TryParse(_txtHDMI_Port.Text ,out hdmiPort))
                MessageBox.Show(this, "The entered value for the HDMI port is not a valid number in the range of "+Byte.MinValue.ToString()+" to "+Byte.MaxValue.ToString()+". Please enter only digits.", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                CEC_Receiver.CEC_Config.HDMI_Port = hdmiPort;


            _cmbDeviceType.Items.Clear();
            foreach (CecSharp.CecDeviceType deviceType in Enum.GetValues(typeof(CecSharp.CecDeviceType)))
            {
                int index = _cmbDeviceType.Items.Add(deviceType);
                if (deviceType == CEC_Receiver.CEC_Config.DeviceType)
                    _cmbDeviceType.SelectedIndex = index;
            }

            CEC_Receiver.CEC_Config.CEC_LogLevel = (CecSharp.CecLogLevel)_cmbLogLevel.SelectedItem;
            CEC_Receiver.CEC_Config.CEC_Vendor = (CecSharp.CecVendorId)_cmbVendorId.SelectedItem;
            CEC_Receiver.CEC_Config.CEC_BaseDevice = (CecSharp.CecLogicalAddress)_cmbBaseDevice.SelectedItem;

            CEC_Receiver.CEC_Config.saveConfig(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"config.cfg"));
        }

        private void InitListViews()
        {
            //KMKL
            _column_KMKL_CECKey.AspectGetter =
                delegate(Object x)
                {
                    string entry = "";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        entry = ((CecSharp.CecUserControlCode)map.CEC_Key).ToString() + " [" + map.CEC_Key.ToString() + "]";
                    }
                    return entry;
                };
            _column_KMKL_KeyboardKey.AspectGetter =
                delegate(Object x)
                {
                    string entry = "";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Key)
                        {
                            Keys key = map.Keyboard_Key.Keys;
                            if ((key & Keys.Shift) == Keys.Shift)
                                key = key ^ Keys.Shift;
                            if ((key & Keys.Alt) == Keys.Alt)
                                key = key ^ Keys.Alt;
                            if ((key & Keys.Control) == Keys.Control)
                                key = key ^ Keys.Control;
                            entry = ((Keys)((int)key)).ToString() + " [" + ((int)key).ToString() + "]";
                        }
                    }
                    return entry;
                };
            _column_KMKL_KeyboardAlt.AspectGetter =
                delegate(Object x)
                {
                    bool entry = false;
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Key)
                        {
                            Keys key = map.Keyboard_Key.Keys;
                            if ((key & Keys.Alt) == Keys.Alt)
                                return true;
                        }
                    }
                    return entry;
                };
            _column_KMKL_KeyboardShift.AspectGetter =
                delegate(Object x)
                {
                    bool entry = false;
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Key)
                        {
                            Keys key = map.Keyboard_Key.Keys;
                            if ((key & Keys.Shift) == Keys.Shift)
                                return true;
                        }
                    }
                    return entry;
                };
            _column_KMKL_KeyboardControl.AspectGetter =
                delegate(Object x)
                {
                    bool entry = false;
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Key)
                        {
                            Keys key = map.Keyboard_Key.Keys;
                            if ((key & Keys.Control) == Keys.Control)
                                return true;
                        }
                    }
                    return entry;
                };
            _column_KMKL_KeyboardKeyMode.AspectGetter =
                delegate(Object x)
                {
                    String mode = "KeyPress";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.KeyPressMode == CEC_Enums.CEC_KeyPressMode.KeyDownUp)
                        {
                            mode = "KeyDown, KeyUp";
                        }
                    }
                    return mode;
                };

            //KMML
            _column_KMML_CECKey.AspectGetter =
                delegate(Object x)
                {
                    string entry = "";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        entry = ((CecSharp.CecUserControlCode)map.CEC_Key).ToString() + " ["+map.CEC_Key.ToString()+"]";
                    }
                    return entry;
                };
            _column_KMML_MakroApp.AspectGetter =
                delegate(Object x)
                {
                    string entry = "";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Makro)
                        {
                            ProcessStartInfo psi = map.Keyboard_Key.Makro;
                            entry = psi.FileName;
                        }
                    }
                    return entry;
                };
            _column_KMML_MakroArgs.AspectGetter =
                delegate(Object x)
                {
                    string entry = "";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Makro)
                        {
                            ProcessStartInfo psi = map.Keyboard_Key.Makro;
                            entry = psi.Arguments;
                        }
                    }
                    return entry;
                };
            _column_KMML_NoWinow.AspectGetter =
                delegate(Object x)
                {
                    bool entry = false;
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Makro)
                        {
                            ProcessStartInfo psi = map.Keyboard_Key.Makro;
                            entry = psi.CreateNoWindow;
                        }
                    }
                    return entry;
                };
            _column_KMML_WindowStyle.AspectGetter =
                delegate(Object x)
                {
                    string entry = "";
                    CEC_KeyMap map = x as CEC_KeyMap;
                    if (map != null)
                    {
                        if (map.Keyboard_Key.Type == CEC_Enums.CEC_KeyboardKey_Type.Makro)
                        {
                            ProcessStartInfo psi = map.Keyboard_Key.Makro;
                            entry = psi.WindowStyle.ToString();
                        }
                    }
                    return entry;
                };           
        }

        private void InitKeyMaps()
        {
            _lstProcessView.SetObjects(CEC_ProcessList.getInstance());
        }

        private void FillKeyMaps(CEC_Process mapping)
        {
            _lstKeyMapKeyList.SetObjects(mapping.KeyMappList.OnlyKeys);
            _lstKeyMapMakroList.SetObjects(mapping.KeyMappList.OnlyMacros);
        }

        private void AddProcess()
        {
            frmProcess processFrm = new frmProcess();
            if (processFrm.ShowDialog() == DialogResult.OK)
            {
                if (CEC_ProcessList.getInstance().Contains(processFrm.ProcessName.Trim()))
                {
                    MessageBox.Show(this, "This process is allready in the list. Please edit instead.","Add new process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CEC_Process process = new CEC_Process(processFrm.ProcessName.Trim());
                process.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"\mapping");
                CEC_ProcessList.getInstance().Add(process);
                InitKeyMaps();
            }
        }

        private void DeleteProcess(CEC_Process process)
        {
            if (MessageBox.Show(this, "Do you realy want delte the process '"+process.ProcessName+"' and all of its mappings?", "Delete process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                process.Delete(System.AppDomain.CurrentDomain.BaseDirectory + @"\mapping");
                CEC_ProcessList.getInstance().Remove(process);
                InitKeyMaps();
            }
        }

        private void AddKeyMap(CEC_Process process)
        {
            frmkeyMap keymapFrm = new frmkeyMap();
            if (keymapFrm.ShowDialog() == DialogResult.OK)
            {
                if (keymapFrm.KeyMap != null)
                {
                    if (process.KeyMappList.Contains(keymapFrm.KeyMap.CEC_Key))
                    {
                        MessageBox.Show(this, "This HDMI CEC key is allready in the list. Please edit instead.", "Add new key mapping", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    process.KeyMappList.Add(keymapFrm.KeyMap);
                    process.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"\mapping");
                    FillKeyMaps(process);
                }
            }
        }

        private void DeleteKeyMap(CEC_Process process, CEC_KeyMap keyMap)
        {
            if (MessageBox.Show(this, "Do you realy want to delte the keymap for HDMI CEC key '"+keyMap.CEC_Key+"' of process '" + process.ProcessName + "'?", "Delete key mapping", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                process.KeyMappList.Remove(keyMap);
                process.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"\mapping");
                FillKeyMaps(process);
            }
        }

        private void _btnSafe_Click(object sender, EventArgs e)
        {
            Safe();
            if (MessageBox.Show(this,"The communication with the adapter (CEC_Receiver) has to be restarted to make the changes used.\r\nShould I restart it now?", "HDMI CEC receiver", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CEC_MapperThread.getInstance().Restart();
            }
            Close();
        }

        private void _btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _tabControl_Enter(object sender, EventArgs e)
        {

        }

        private void _tabControl_Selected(object sender, TabControlEventArgs e)
        {
            InitKeyMaps();
        }

        private void _lstProcessView_SelectionChanged(object sender, EventArgs e)
        {
            if (_lstProcessView.SelectedObjects.Count <= 0)
                return;
            CEC_Process mapping = _lstProcessView.SelectedObjects[0] as CEC_Process;
            if (mapping != null)
                FillKeyMaps(mapping);
        }

        private void _btnProcessAdd_Click(object sender, EventArgs e)
        {
            AddProcess();
        }

        private void _btnProcessDelete_Click(object sender, EventArgs e)
        {
            if (_lstProcessView.SelectedObjects.Count <= 0)
            {
                MessageBox.Show(this, "Please select a process.", "Delete a process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CEC_Process process = _lstProcessView.SelectedObjects[0] as CEC_Process;
            if (process != null)
                DeleteProcess(process);
        }

        private void _btnKeyMapAdd_Click(object sender, EventArgs e)
        {
            if (_lstProcessView.SelectedObjects.Count <= 0)
            {
                MessageBox.Show(this, "Please select a process.", "Add a keymap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CEC_Process process = _lstProcessView.SelectedObjects[0] as CEC_Process;
            if (process != null)
                AddKeyMap(process);
        }

        private void _btnKeyMapDelete_Click(object sender, EventArgs e)
        {
            if (_lstProcessView.SelectedObjects.Count <= 0)
            {
                MessageBox.Show(this, "Please select a process.", "Delete a keymap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CEC_Process process = _lstProcessView.SelectedObjects[0] as CEC_Process;

            if (_lstKeyMapKeyList.SelectedObjects.Count <= 0 && _lstKeyMapMakroList.SelectedObjects.Count <= 0)
            {
                MessageBox.Show(this, "Please select either a keymap key or a keymap macro.", "Delete a keymap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_lstKeyMapKeyList.SelectedObjects.Count > 0 && _lstKeyMapMakroList.SelectedObjects.Count > 0)
            {
                MessageBox.Show(this, "Please select only a keymap key OR a keymap macor, not both.", "Delete a keymap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CEC_KeyMap keyMap = null;
            if (_lstKeyMapKeyList.SelectedObjects.Count > 0)
                keyMap = _lstKeyMapKeyList.SelectedObjects[0] as CEC_KeyMap;
            else if (_lstKeyMapMakroList.SelectedObjects.Count > 0)
                keyMap = _lstKeyMapMakroList.SelectedObjects[0] as CEC_KeyMap;

            if (process != null && keyMap != null)
                DeleteKeyMap(process,keyMap);
        }

        private void _lstKeyMapKeyList_SelectionChanged(object sender, EventArgs e)
        {
            _lstKeyMapMakroList.DeselectAll();
        }

        private void _lstKeyMapMakroList_SelectionChanged(object sender, EventArgs e)
        {
            _lstKeyMapKeyList.DeselectAll();
        }

        private void _tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == _tabPage_LibCEC)
            {
                this.Size = new Size(540,390);
            }
            else
            {
                this.Size = new Size(1200,420);
            }
        }

    }
}
