namespace billy_boy.CEC_Mapper
{
    partial class frmkeyMap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkeyMap));
            this._lbl_CECKey = new System.Windows.Forms.Label();
            this._cmb_CECKey = new System.Windows.Forms.ComboBox();
            this._radio_Key = new System.Windows.Forms.RadioButton();
            this._radio_Macro = new System.Windows.Forms.RadioButton();
            this._txt_KeyboardKey = new System.Windows.Forms.TextBox();
            this._chk_Shift = new System.Windows.Forms.CheckBox();
            this._chk_Alt = new System.Windows.Forms.CheckBox();
            this._chkCtrl = new System.Windows.Forms.CheckBox();
            this._lbl_KeyboardKey = new System.Windows.Forms.Label();
            this._lblFile = new System.Windows.Forms.Label();
            this._txtFile = new System.Windows.Forms.TextBox();
            this._lblArguments = new System.Windows.Forms.Label();
            this._txtArguments = new System.Windows.Forms.TextBox();
            this._cmbWindowState = new System.Windows.Forms.ComboBox();
            this._lblWindowState = new System.Windows.Forms.Label();
            this._chkCreateNoWindow = new System.Windows.Forms.CheckBox();
            this._btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lbl_CECKey
            // 
            this._lbl_CECKey.AutoSize = true;
            this._lbl_CECKey.Location = new System.Drawing.Point(12, 15);
            this._lbl_CECKey.Name = "_lbl_CECKey";
            this._lbl_CECKey.Size = new System.Drawing.Size(83, 13);
            this._lbl_CECKey.TabIndex = 1;
            this._lbl_CECKey.Text = "HDMI CEC Key:";
            // 
            // _cmb_CECKey
            // 
            this._cmb_CECKey.FormattingEnabled = true;
            this._cmb_CECKey.Location = new System.Drawing.Point(101, 12);
            this._cmb_CECKey.Name = "_cmb_CECKey";
            this._cmb_CECKey.Size = new System.Drawing.Size(200, 21);
            this._cmb_CECKey.TabIndex = 2;
            // 
            // _radio_Key
            // 
            this._radio_Key.AutoSize = true;
            this._radio_Key.Checked = true;
            this._radio_Key.Location = new System.Drawing.Point(15, 39);
            this._radio_Key.Name = "_radio_Key";
            this._radio_Key.Size = new System.Drawing.Size(132, 17);
            this._radio_Key.TabIndex = 3;
            this._radio_Key.TabStop = true;
            this._radio_Key.Text = "keyboard key mapping";
            this._radio_Key.UseVisualStyleBackColor = true;
            this._radio_Key.CheckedChanged += new System.EventHandler(this._radio_Key_CheckedChanged);
            // 
            // _radio_Macro
            // 
            this._radio_Macro.AutoSize = true;
            this._radio_Macro.Location = new System.Drawing.Point(153, 39);
            this._radio_Macro.Name = "_radio_Macro";
            this._radio_Macro.Size = new System.Drawing.Size(54, 17);
            this._radio_Macro.TabIndex = 4;
            this._radio_Macro.Text = "macro";
            this._radio_Macro.UseVisualStyleBackColor = true;
            this._radio_Macro.CheckedChanged += new System.EventHandler(this._radio_Macro_CheckedChanged);
            // 
            // _txt_KeyboardKey
            // 
            this._txt_KeyboardKey.Location = new System.Drawing.Point(101, 65);
            this._txt_KeyboardKey.Name = "_txt_KeyboardKey";
            this._txt_KeyboardKey.Size = new System.Drawing.Size(200, 20);
            this._txt_KeyboardKey.TabIndex = 5;
            this._txt_KeyboardKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txt_KeyboardKey_KeyPress);
            // 
            // _chk_Shift
            // 
            this._chk_Shift.AutoSize = true;
            this._chk_Shift.Location = new System.Drawing.Point(101, 91);
            this._chk_Shift.Name = "_chk_Shift";
            this._chk_Shift.Size = new System.Drawing.Size(47, 17);
            this._chk_Shift.TabIndex = 6;
            this._chk_Shift.Text = "Shift";
            this._chk_Shift.UseVisualStyleBackColor = true;
            // 
            // _chk_Alt
            // 
            this._chk_Alt.AutoSize = true;
            this._chk_Alt.Location = new System.Drawing.Point(187, 91);
            this._chk_Alt.Name = "_chk_Alt";
            this._chk_Alt.Size = new System.Drawing.Size(38, 17);
            this._chk_Alt.TabIndex = 7;
            this._chk_Alt.Text = "Alt";
            this._chk_Alt.UseVisualStyleBackColor = true;
            // 
            // _chkCtrl
            // 
            this._chkCtrl.AutoSize = true;
            this._chkCtrl.Location = new System.Drawing.Point(101, 114);
            this._chkCtrl.Name = "_chkCtrl";
            this._chkCtrl.Size = new System.Drawing.Size(41, 17);
            this._chkCtrl.TabIndex = 8;
            this._chkCtrl.Text = "Ctrl";
            this._chkCtrl.UseVisualStyleBackColor = true;
            // 
            // _lbl_KeyboardKey
            // 
            this._lbl_KeyboardKey.AutoSize = true;
            this._lbl_KeyboardKey.Location = new System.Drawing.Point(12, 68);
            this._lbl_KeyboardKey.Name = "_lbl_KeyboardKey";
            this._lbl_KeyboardKey.Size = new System.Drawing.Size(75, 13);
            this._lbl_KeyboardKey.TabIndex = 9;
            this._lbl_KeyboardKey.Text = "Keyboard key:";
            // 
            // _lblFile
            // 
            this._lblFile.AutoSize = true;
            this._lblFile.Location = new System.Drawing.Point(14, 140);
            this._lblFile.Name = "_lblFile";
            this._lblFile.Size = new System.Drawing.Size(79, 13);
            this._lblFile.TabIndex = 11;
            this._lblFile.Text = "File to execute:";
            // 
            // _txtFile
            // 
            this._txtFile.Location = new System.Drawing.Point(103, 137);
            this._txtFile.Name = "_txtFile";
            this._txtFile.Size = new System.Drawing.Size(200, 20);
            this._txtFile.TabIndex = 10;
            // 
            // _lblArguments
            // 
            this._lblArguments.AutoSize = true;
            this._lblArguments.Location = new System.Drawing.Point(14, 166);
            this._lblArguments.Name = "_lblArguments";
            this._lblArguments.Size = new System.Drawing.Size(60, 13);
            this._lblArguments.TabIndex = 13;
            this._lblArguments.Text = "Arguments:";
            // 
            // _txtArguments
            // 
            this._txtArguments.Location = new System.Drawing.Point(103, 163);
            this._txtArguments.Name = "_txtArguments";
            this._txtArguments.Size = new System.Drawing.Size(200, 20);
            this._txtArguments.TabIndex = 12;
            // 
            // _cmbWindowState
            // 
            this._cmbWindowState.FormattingEnabled = true;
            this._cmbWindowState.Location = new System.Drawing.Point(101, 189);
            this._cmbWindowState.Name = "_cmbWindowState";
            this._cmbWindowState.Size = new System.Drawing.Size(200, 21);
            this._cmbWindowState.TabIndex = 15;
            // 
            // _lblWindowState
            // 
            this._lblWindowState.AutoSize = true;
            this._lblWindowState.Location = new System.Drawing.Point(12, 192);
            this._lblWindowState.Name = "_lblWindowState";
            this._lblWindowState.Size = new System.Drawing.Size(75, 13);
            this._lblWindowState.TabIndex = 14;
            this._lblWindowState.Text = "Window state:";
            // 
            // _chkCreateNoWindow
            // 
            this._chkCreateNoWindow.AutoSize = true;
            this._chkCreateNoWindow.Location = new System.Drawing.Point(103, 216);
            this._chkCreateNoWindow.Name = "_chkCreateNoWindow";
            this._chkCreateNoWindow.Size = new System.Drawing.Size(111, 17);
            this._chkCreateNoWindow.TabIndex = 16;
            this._chkCreateNoWindow.Text = "Create no window";
            this._chkCreateNoWindow.UseVisualStyleBackColor = true;
            // 
            // _btnOk
            // 
            this._btnOk.Location = new System.Drawing.Point(17, 239);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(284, 23);
            this._btnOk.TabIndex = 17;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // frmkeyMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 278);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._chkCreateNoWindow);
            this.Controls.Add(this._cmbWindowState);
            this.Controls.Add(this._lblWindowState);
            this.Controls.Add(this._lblArguments);
            this.Controls.Add(this._txtArguments);
            this.Controls.Add(this._lblFile);
            this.Controls.Add(this._txtFile);
            this.Controls.Add(this._lbl_KeyboardKey);
            this.Controls.Add(this._chkCtrl);
            this.Controls.Add(this._chk_Alt);
            this.Controls.Add(this._chk_Shift);
            this.Controls.Add(this._txt_KeyboardKey);
            this.Controls.Add(this._radio_Macro);
            this.Controls.Add(this._radio_Key);
            this.Controls.Add(this._cmb_CECKey);
            this.Controls.Add(this._lbl_CECKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmkeyMap";
            this.Text = "Add a new key map entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lbl_CECKey;
        private System.Windows.Forms.ComboBox _cmb_CECKey;
        private System.Windows.Forms.RadioButton _radio_Key;
        private System.Windows.Forms.RadioButton _radio_Macro;
        private System.Windows.Forms.TextBox _txt_KeyboardKey;
        private System.Windows.Forms.CheckBox _chk_Shift;
        private System.Windows.Forms.CheckBox _chk_Alt;
        private System.Windows.Forms.CheckBox _chkCtrl;
        private System.Windows.Forms.Label _lbl_KeyboardKey;
        private System.Windows.Forms.Label _lblFile;
        private System.Windows.Forms.TextBox _txtFile;
        private System.Windows.Forms.Label _lblArguments;
        private System.Windows.Forms.TextBox _txtArguments;
        private System.Windows.Forms.ComboBox _cmbWindowState;
        private System.Windows.Forms.Label _lblWindowState;
        private System.Windows.Forms.CheckBox _chkCreateNoWindow;
        private System.Windows.Forms.Button _btnOk;
    }
}