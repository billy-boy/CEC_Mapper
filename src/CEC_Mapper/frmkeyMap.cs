using billy_boy.CEC_Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace billy_boy.CEC_Mapper
{
    public partial class frmkeyMap : Form
    {
        private CEC_KeyMap _map = null;

        public frmkeyMap()
        {
            InitializeComponent();
            Init();
            DialogResult = DialogResult.Cancel;
        }

        private void Init()
        {
            _cmb_CECKey.Items.Clear();
            foreach (CecSharp.CecUserControlCode code in Enum.GetValues(typeof(CecSharp.CecUserControlCode)))
            {
                int index = _cmb_CECKey.Items.Add(code);
            }

            _cmbWindowState.Items.Clear();
            foreach (System.Diagnostics.ProcessWindowStyle code in Enum.GetValues(typeof(System.Diagnostics.ProcessWindowStyle)))
            {
                int index = _cmbWindowState.Items.Add(code);
                if (code == ProcessWindowStyle.Normal)
                    _cmbWindowState.SelectedItem = index;
            }

            _cmbKeyboardKeyMode.Items.Clear();
            foreach (CEC_Enums.CEC_KeyPressMode mode in Enum.GetValues(typeof(CEC_Enums.CEC_KeyPressMode)))
            {
                int index = _cmbKeyboardKeyMode.Items.Add(mode);
                if (mode  == CEC_Enums.CEC_KeyPressMode.KeyPress)
                    _cmbKeyboardKeyMode.SelectedItem = index;
            }

            keyEnabled(true);
            macroEnabled(false);
        }

        private void keyEnabled(bool enabled)
        {
            _txt_KeyboardKey.Visible = enabled;
            _chk_Alt.Visible = enabled;
            _chk_Shift.Visible = enabled;
            _chkCtrl.Visible = enabled;
            _lbl_KeyboardKey.Visible = enabled;
            _cmbKeyboardKeyMode.Visible = enabled;
            _btnKeyHelp.Visible = enabled;
        }

        private void macroEnabled(bool enabled)
        {
            _lblFile.Visible = enabled;
            _txtFile.Visible = enabled;
            _lblArguments.Visible = enabled;
            _txtArguments.Visible = enabled;
            _lblWindowState.Visible = enabled;
            _cmbWindowState.Visible = enabled;
            _chkCreateNoWindow.Visible = enabled;
        }

        private bool Save()
        {
            if (_cmb_CECKey.SelectedItem == null)
            {
                MessageBox.Show(this, "You have to select an HDMI CEC key.\r\nThis is the key on your remote which will be translated by this app.", "Add a new key map", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            CEC_KeyboardKey keyboardKey = null;

            if (_radio_Key.Checked)
            {
                Int32 keyCode = 0;
                if (!Int32.TryParse(_txt_KeyboardKey.Text.Trim(), out keyCode))
                {
                    MessageBox.Show(this, "The keyboard key must be entered as it's 32-bit Integer value.\r\nPlease read the ReadMe file.", "Add a new key map", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (_cmbKeyboardKeyMode.SelectedItem == null)
                {
                    MessageBox.Show(this, "Please select a keyboard key mode.\r\nPlease read the ReadMe file.", "Add a new key map", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                Keys key = (Keys)keyCode;
                if (_chk_Shift.Checked)
                    key = key | Keys.Shift;
                if (_chk_Alt.Checked)
                    key = key | Keys.Alt;
                if (_chkCtrl.Checked)
                    key = key | Keys.Control;
                keyboardKey = new CEC_KeyboardKey(key,(CEC_Enums.CEC_KeyPressMode)_cmbKeyboardKeyMode.SelectedItem);
            }
            else if (_radio_Macro.Checked)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = _txtFile.Text;
                psi.Arguments = _txtArguments.Text;
                psi.CreateNoWindow = _chkCreateNoWindow.Checked;
                psi.WindowStyle = (ProcessWindowStyle)_cmbWindowState.SelectedItem;
                keyboardKey = new CEC_KeyboardKey(psi);
            }

            if (keyboardKey != null)
            {
                _map = new CEC_KeyMap((int)_cmb_CECKey.SelectedItem, keyboardKey);
                return true;
            }

            return false;
        }

        private void _radio_Key_CheckedChanged(object sender, EventArgs e)
        {
            keyEnabled(false);
            macroEnabled(false);
            if (_radio_Key.Checked)
            {
                keyEnabled(true);
            }
        }

        private void _radio_Macro_CheckedChanged(object sender, EventArgs e)
        {
            keyEnabled(false);
            macroEnabled(false);
            if (_radio_Macro.Checked)
            {
                macroEnabled(true);
            }
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show(this, "Could not save. Please check your settings.", "Add a new key map", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public CEC_KeyMap KeyMap { get { return _map;  } }

        private void _txt_KeyboardKey_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void _btnKeyHelp_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"key_check.exe")))
            {
                ProcessStartInfo psi = new ProcessStartInfo(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"key_check.exe"));
                Process.Start(psi);
            }
        }
    }
}
