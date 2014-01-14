namespace billy_boy.CEC_Mapper
{
    partial class frmConfig
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPageLibCEC = new System.Windows.Forms.TabPage();
            this._pictLogo = new System.Windows.Forms.PictureBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnSafe = new System.Windows.Forms.Button();
            this._lblBaseDevice = new System.Windows.Forms.Label();
            this._cmbBaseDevice = new System.Windows.Forms.ComboBox();
            this._txtHDMI_Port = new System.Windows.Forms.TextBox();
            this._lblHDMI_Port = new System.Windows.Forms.Label();
            this._lblVendorId = new System.Windows.Forms.Label();
            this._lblLogLevel = new System.Windows.Forms.Label();
            this._cmbVendorId = new System.Windows.Forms.ComboBox();
            this._cmbLogLevel = new System.Windows.Forms.ComboBox();
            this._lblConnectionTimeout = new System.Windows.Forms.Label();
            this._txtConnectionTimeout = new System.Windows.Forms.TextBox();
            this._txtDeviceName = new System.Windows.Forms.TextBox();
            this._lblDeviceName = new System.Windows.Forms.Label();
            this._cmbDeviceType = new System.Windows.Forms.ComboBox();
            this._lblDeviceType = new System.Windows.Forms.Label();
            this._lblInformation = new System.Windows.Forms.Label();
            this._tabKeyMapping = new System.Windows.Forms.TabPage();
            this._lblInfo = new System.Windows.Forms.Label();
            this._btnKeyMapDelete = new System.Windows.Forms.Button();
            this._btnKeyMapAdd = new System.Windows.Forms.Button();
            this._btnProcessDelete = new System.Windows.Forms.Button();
            this._btnProcessAdd = new System.Windows.Forms.Button();
            this._lstKeyMapMakroList = new BrightIdeasSoftware.ObjectListView();
            this._column_KMML_CECKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMML_MakroApp = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMML_MakroArgs = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMML_NoWinow = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMML_WindowStyle = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._lstKeyMapKeyList = new BrightIdeasSoftware.ObjectListView();
            this._column_KMKL_CECKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardShift = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardAlt = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardControl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._lstProcessView = new BrightIdeasSoftware.ObjectListView();
            this._columnProcessName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._tabControl.SuspendLayout();
            this._tabPageLibCEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictLogo)).BeginInit();
            this._tabKeyMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapMakroList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapKeyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstProcessView)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPageLibCEC);
            this._tabControl.Controls.Add(this._tabKeyMapping);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1101, 380);
            this._tabControl.TabIndex = 0;
            this._tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this._tabControl_Selected);
            this._tabControl.Enter += new System.EventHandler(this._tabControl_Enter);
            // 
            // _tabPageLibCEC
            // 
            this._tabPageLibCEC.Controls.Add(this._pictLogo);
            this._tabPageLibCEC.Controls.Add(this._btnCancel);
            this._tabPageLibCEC.Controls.Add(this._btnSafe);
            this._tabPageLibCEC.Controls.Add(this._lblBaseDevice);
            this._tabPageLibCEC.Controls.Add(this._cmbBaseDevice);
            this._tabPageLibCEC.Controls.Add(this._txtHDMI_Port);
            this._tabPageLibCEC.Controls.Add(this._lblHDMI_Port);
            this._tabPageLibCEC.Controls.Add(this._lblVendorId);
            this._tabPageLibCEC.Controls.Add(this._lblLogLevel);
            this._tabPageLibCEC.Controls.Add(this._cmbVendorId);
            this._tabPageLibCEC.Controls.Add(this._cmbLogLevel);
            this._tabPageLibCEC.Controls.Add(this._lblConnectionTimeout);
            this._tabPageLibCEC.Controls.Add(this._txtConnectionTimeout);
            this._tabPageLibCEC.Controls.Add(this._txtDeviceName);
            this._tabPageLibCEC.Controls.Add(this._lblDeviceName);
            this._tabPageLibCEC.Controls.Add(this._cmbDeviceType);
            this._tabPageLibCEC.Controls.Add(this._lblDeviceType);
            this._tabPageLibCEC.Controls.Add(this._lblInformation);
            this._tabPageLibCEC.Location = new System.Drawing.Point(4, 22);
            this._tabPageLibCEC.Name = "_tabPageLibCEC";
            this._tabPageLibCEC.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageLibCEC.Size = new System.Drawing.Size(1093, 354);
            this._tabPageLibCEC.TabIndex = 0;
            this._tabPageLibCEC.Text = "HDMI CEC";
            this._tabPageLibCEC.UseVisualStyleBackColor = true;
            // 
            // _pictLogo
            // 
            this._pictLogo.Location = new System.Drawing.Point(463, 51);
            this._pictLogo.Name = "_pictLogo";
            this._pictLogo.Size = new System.Drawing.Size(256, 256);
            this._pictLogo.TabIndex = 17;
            this._pictLogo.TabStop = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(167, 284);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(202, 23);
            this._btnCancel.TabIndex = 16;
            this._btnCancel.Text = "Abbrechen";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnSafe
            // 
            this._btnSafe.Location = new System.Drawing.Point(11, 284);
            this._btnSafe.Name = "_btnSafe";
            this._btnSafe.Size = new System.Drawing.Size(150, 23);
            this._btnSafe.TabIndex = 15;
            this._btnSafe.Text = "Speichern";
            this._btnSafe.UseVisualStyleBackColor = true;
            this._btnSafe.Click += new System.EventHandler(this._btnSafe_Click);
            // 
            // _lblBaseDevice
            // 
            this._lblBaseDevice.AutoSize = true;
            this._lblBaseDevice.Location = new System.Drawing.Point(8, 213);
            this._lblBaseDevice.Name = "_lblBaseDevice";
            this._lblBaseDevice.Size = new System.Drawing.Size(69, 13);
            this._lblBaseDevice.TabIndex = 14;
            this._lblBaseDevice.Text = "Base device:";
            // 
            // _cmbBaseDevice
            // 
            this._cmbBaseDevice.FormattingEnabled = true;
            this._cmbBaseDevice.Location = new System.Drawing.Point(167, 210);
            this._cmbBaseDevice.Name = "_cmbBaseDevice";
            this._cmbBaseDevice.Size = new System.Drawing.Size(202, 21);
            this._cmbBaseDevice.TabIndex = 13;
            this._toolTip.SetToolTip(this._cmbBaseDevice, "The HDMI CEC device to which this adapter is connected to.");
            // 
            // _txtHDMI_Port
            // 
            this._txtHDMI_Port.Location = new System.Drawing.Point(167, 184);
            this._txtHDMI_Port.Name = "_txtHDMI_Port";
            this._txtHDMI_Port.Size = new System.Drawing.Size(202, 20);
            this._txtHDMI_Port.TabIndex = 12;
            this._toolTip.SetToolTip(this._txtHDMI_Port, "The HDMI port number on which this device is connected to it\'s base device. It is" +
        " important that this information is correct!");
            // 
            // _lblHDMI_Port
            // 
            this._lblHDMI_Port.AutoSize = true;
            this._lblHDMI_Port.Location = new System.Drawing.Point(8, 187);
            this._lblHDMI_Port.Name = "_lblHDMI_Port";
            this._lblHDMI_Port.Size = new System.Drawing.Size(59, 13);
            this._lblHDMI_Port.TabIndex = 11;
            this._lblHDMI_Port.Text = "HDMI port:";
            // 
            // _lblVendorId
            // 
            this._lblVendorId.AutoSize = true;
            this._lblVendorId.Location = new System.Drawing.Point(8, 160);
            this._lblVendorId.Name = "_lblVendorId";
            this._lblVendorId.Size = new System.Drawing.Size(56, 13);
            this._lblVendorId.TabIndex = 10;
            this._lblVendorId.Text = "Vendor Id:";
            // 
            // _lblLogLevel
            // 
            this._lblLogLevel.AutoSize = true;
            this._lblLogLevel.Location = new System.Drawing.Point(8, 133);
            this._lblLogLevel.Name = "_lblLogLevel";
            this._lblLogLevel.Size = new System.Drawing.Size(73, 13);
            this._lblLogLevel.TabIndex = 9;
            this._lblLogLevel.Text = "CEC log level:";
            // 
            // _cmbVendorId
            // 
            this._cmbVendorId.FormattingEnabled = true;
            this._cmbVendorId.Location = new System.Drawing.Point(167, 157);
            this._cmbVendorId.Name = "_cmbVendorId";
            this._cmbVendorId.Size = new System.Drawing.Size(202, 21);
            this._cmbVendorId.TabIndex = 8;
            this._toolTip.SetToolTip(this._cmbVendorId, "TV\'s vendor information for CEC vendor specific communication");
            // 
            // _cmbLogLevel
            // 
            this._cmbLogLevel.FormattingEnabled = true;
            this._cmbLogLevel.Location = new System.Drawing.Point(167, 130);
            this._cmbLogLevel.Name = "_cmbLogLevel";
            this._cmbLogLevel.Size = new System.Drawing.Size(202, 21);
            this._cmbLogLevel.TabIndex = 7;
            this._toolTip.SetToolTip(this._cmbLogLevel, "Log level for the HDMI CEC adapter. Attention: If you want to see the adapter\'s l" +
        "og you have to enable application loging with debug options.");
            // 
            // _lblConnectionTimeout
            // 
            this._lblConnectionTimeout.AutoSize = true;
            this._lblConnectionTimeout.Location = new System.Drawing.Point(8, 107);
            this._lblConnectionTimeout.Name = "_lblConnectionTimeout";
            this._lblConnectionTimeout.Size = new System.Drawing.Size(101, 13);
            this._lblConnectionTimeout.TabIndex = 6;
            this._lblConnectionTimeout.Text = "Connection timeout:";
            // 
            // _txtConnectionTimeout
            // 
            this._txtConnectionTimeout.Location = new System.Drawing.Point(167, 104);
            this._txtConnectionTimeout.Name = "_txtConnectionTimeout";
            this._txtConnectionTimeout.Size = new System.Drawing.Size(202, 20);
            this._txtConnectionTimeout.TabIndex = 5;
            this._toolTip.SetToolTip(this._txtConnectionTimeout, "Timeout for connection to HDMI CEC adapter");
            // 
            // _txtDeviceName
            // 
            this._txtDeviceName.Location = new System.Drawing.Point(167, 78);
            this._txtDeviceName.Name = "_txtDeviceName";
            this._txtDeviceName.Size = new System.Drawing.Size(202, 20);
            this._txtDeviceName.TabIndex = 4;
            this._toolTip.SetToolTip(this._txtDeviceName, "The name of this device shown in all HDMI CEC components");
            // 
            // _lblDeviceName
            // 
            this._lblDeviceName.AutoSize = true;
            this._lblDeviceName.Location = new System.Drawing.Point(8, 81);
            this._lblDeviceName.Name = "_lblDeviceName";
            this._lblDeviceName.Size = new System.Drawing.Size(73, 13);
            this._lblDeviceName.TabIndex = 3;
            this._lblDeviceName.Text = "Device name:";
            // 
            // _cmbDeviceType
            // 
            this._cmbDeviceType.FormattingEnabled = true;
            this._cmbDeviceType.Location = new System.Drawing.Point(167, 51);
            this._cmbDeviceType.Name = "_cmbDeviceType";
            this._cmbDeviceType.Size = new System.Drawing.Size(202, 21);
            this._cmbDeviceType.TabIndex = 2;
            this._toolTip.SetToolTip(this._cmbDeviceType, "The HDMI CEC type of this device. Default: RecordingDevice");
            // 
            // _lblDeviceType
            // 
            this._lblDeviceType.AutoSize = true;
            this._lblDeviceType.Location = new System.Drawing.Point(8, 54);
            this._lblDeviceType.Name = "_lblDeviceType";
            this._lblDeviceType.Size = new System.Drawing.Size(67, 13);
            this._lblDeviceType.TabIndex = 1;
            this._lblDeviceType.Text = "Device type:";
            // 
            // _lblInformation
            // 
            this._lblInformation.AutoSize = true;
            this._lblInformation.Location = new System.Drawing.Point(8, 12);
            this._lblInformation.Name = "_lblInformation";
            this._lblInformation.Size = new System.Drawing.Size(712, 13);
            this._lblInformation.TabIndex = 0;
            this._lblInformation.Text = "Auf dieser Registerkarte werden alle Einstellungen vorgenommen, welche zum korrek" +
    "ten Betrieb des HDMI CEC Adapters via libCEC benötigt werden.";
            // 
            // _tabKeyMapping
            // 
            this._tabKeyMapping.Controls.Add(this._lblInfo);
            this._tabKeyMapping.Controls.Add(this._btnKeyMapDelete);
            this._tabKeyMapping.Controls.Add(this._btnKeyMapAdd);
            this._tabKeyMapping.Controls.Add(this._btnProcessDelete);
            this._tabKeyMapping.Controls.Add(this._btnProcessAdd);
            this._tabKeyMapping.Controls.Add(this._lstKeyMapMakroList);
            this._tabKeyMapping.Controls.Add(this._lstKeyMapKeyList);
            this._tabKeyMapping.Controls.Add(this._lstProcessView);
            this._tabKeyMapping.Location = new System.Drawing.Point(4, 22);
            this._tabKeyMapping.Name = "_tabKeyMapping";
            this._tabKeyMapping.Padding = new System.Windows.Forms.Padding(3);
            this._tabKeyMapping.Size = new System.Drawing.Size(1093, 354);
            this._tabKeyMapping.TabIndex = 1;
            this._tabKeyMapping.Text = "Key Mapping List";
            this._tabKeyMapping.UseVisualStyleBackColor = true;
            // 
            // _lblInfo
            // 
            this._lblInfo.AutoSize = true;
            this._lblInfo.Location = new System.Drawing.Point(882, 324);
            this._lblInfo.Name = "_lblInfo";
            this._lblInfo.Size = new System.Drawing.Size(203, 13);
            this._lblInfo.TabIndex = 7;
            this._lblInfo.Text = "Warning: Changes will happen imediately!";
            // 
            // _btnKeyMapDelete
            // 
            this._btnKeyMapDelete.Image = ((System.Drawing.Image)(resources.GetObject("_btnKeyMapDelete.Image")));
            this._btnKeyMapDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKeyMapDelete.Location = new System.Drawing.Point(299, 319);
            this._btnKeyMapDelete.Name = "_btnKeyMapDelete";
            this._btnKeyMapDelete.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._btnKeyMapDelete.Size = new System.Drawing.Size(75, 23);
            this._btnKeyMapDelete.TabIndex = 6;
            this._btnKeyMapDelete.Text = "Delete";
            this._btnKeyMapDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnKeyMapDelete.UseVisualStyleBackColor = true;
            this._btnKeyMapDelete.Click += new System.EventHandler(this._btnKeyMapDelete_Click);
            // 
            // _btnKeyMapAdd
            // 
            this._btnKeyMapAdd.Image = ((System.Drawing.Image)(resources.GetObject("_btnKeyMapAdd.Image")));
            this._btnKeyMapAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKeyMapAdd.Location = new System.Drawing.Point(218, 319);
            this._btnKeyMapAdd.Name = "_btnKeyMapAdd";
            this._btnKeyMapAdd.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._btnKeyMapAdd.Size = new System.Drawing.Size(75, 23);
            this._btnKeyMapAdd.TabIndex = 5;
            this._btnKeyMapAdd.Text = "Add";
            this._btnKeyMapAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnKeyMapAdd.UseVisualStyleBackColor = true;
            this._btnKeyMapAdd.Click += new System.EventHandler(this._btnKeyMapAdd_Click);
            // 
            // _btnProcessDelete
            // 
            this._btnProcessDelete.Image = ((System.Drawing.Image)(resources.GetObject("_btnProcessDelete.Image")));
            this._btnProcessDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProcessDelete.Location = new System.Drawing.Point(90, 319);
            this._btnProcessDelete.Name = "_btnProcessDelete";
            this._btnProcessDelete.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._btnProcessDelete.Size = new System.Drawing.Size(75, 23);
            this._btnProcessDelete.TabIndex = 4;
            this._btnProcessDelete.Text = "Delete";
            this._btnProcessDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnProcessDelete.UseVisualStyleBackColor = true;
            this._btnProcessDelete.Click += new System.EventHandler(this._btnProcessDelete_Click);
            // 
            // _btnProcessAdd
            // 
            this._btnProcessAdd.Image = ((System.Drawing.Image)(resources.GetObject("_btnProcessAdd.Image")));
            this._btnProcessAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProcessAdd.Location = new System.Drawing.Point(9, 319);
            this._btnProcessAdd.Name = "_btnProcessAdd";
            this._btnProcessAdd.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this._btnProcessAdd.Size = new System.Drawing.Size(75, 23);
            this._btnProcessAdd.TabIndex = 3;
            this._btnProcessAdd.Text = "Add";
            this._btnProcessAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnProcessAdd.UseVisualStyleBackColor = true;
            this._btnProcessAdd.Click += new System.EventHandler(this._btnProcessAdd_Click);
            // 
            // _lstKeyMapMakroList
            // 
            this._lstKeyMapMakroList.AllColumns.Add(this._column_KMML_CECKey);
            this._lstKeyMapMakroList.AllColumns.Add(this._column_KMML_MakroApp);
            this._lstKeyMapMakroList.AllColumns.Add(this._column_KMML_MakroArgs);
            this._lstKeyMapMakroList.AllColumns.Add(this._column_KMML_NoWinow);
            this._lstKeyMapMakroList.AllColumns.Add(this._column_KMML_WindowStyle);
            this._lstKeyMapMakroList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_KMML_CECKey,
            this._column_KMML_MakroApp,
            this._column_KMML_MakroArgs,
            this._column_KMML_NoWinow,
            this._column_KMML_WindowStyle});
            this._lstKeyMapMakroList.FullRowSelect = true;
            this._lstKeyMapMakroList.Location = new System.Drawing.Point(218, 162);
            this._lstKeyMapMakroList.Name = "_lstKeyMapMakroList";
            this._lstKeyMapMakroList.Size = new System.Drawing.Size(867, 150);
            this._lstKeyMapMakroList.TabIndex = 2;
            this._lstKeyMapMakroList.UseCompatibleStateImageBehavior = false;
            this._lstKeyMapMakroList.View = System.Windows.Forms.View.Details;
            this._lstKeyMapMakroList.SelectionChanged += new System.EventHandler(this._lstKeyMapMakroList_SelectionChanged);
            // 
            // _column_KMML_CECKey
            // 
            this._column_KMML_CECKey.Groupable = false;
            this._column_KMML_CECKey.IsEditable = false;
            this._column_KMML_CECKey.Text = "CEC key";
            this._column_KMML_CECKey.ToolTipText = "The name of the process";
            this._column_KMML_CECKey.Width = 150;
            // 
            // _column_KMML_MakroApp
            // 
            this._column_KMML_MakroApp.FillsFreeSpace = true;
            this._column_KMML_MakroApp.Groupable = false;
            this._column_KMML_MakroApp.IsEditable = false;
            this._column_KMML_MakroApp.Text = "Application";
            this._column_KMML_MakroApp.Width = 300;
            // 
            // _column_KMML_MakroArgs
            // 
            this._column_KMML_MakroArgs.Groupable = false;
            this._column_KMML_MakroArgs.IsEditable = false;
            this._column_KMML_MakroArgs.Text = "Arguments";
            this._column_KMML_MakroArgs.Width = 150;
            // 
            // _column_KMML_NoWinow
            // 
            this._column_KMML_NoWinow.CheckBoxes = true;
            this._column_KMML_NoWinow.Groupable = false;
            this._column_KMML_NoWinow.IsEditable = false;
            this._column_KMML_NoWinow.Text = "NoWindow";
            this._column_KMML_NoWinow.Width = 70;
            // 
            // _column_KMML_WindowStyle
            // 
            this._column_KMML_WindowStyle.Groupable = false;
            this._column_KMML_WindowStyle.IsEditable = false;
            this._column_KMML_WindowStyle.Text = "WindowStyle";
            this._column_KMML_WindowStyle.Width = 100;
            // 
            // _lstKeyMapKeyList
            // 
            this._lstKeyMapKeyList.AllColumns.Add(this._column_KMKL_CECKey);
            this._lstKeyMapKeyList.AllColumns.Add(this._column_KMKL_KeyboardKey);
            this._lstKeyMapKeyList.AllColumns.Add(this._column_KMKL_KeyboardShift);
            this._lstKeyMapKeyList.AllColumns.Add(this._column_KMKL_KeyboardAlt);
            this._lstKeyMapKeyList.AllColumns.Add(this._column_KMKL_KeyboardControl);
            this._lstKeyMapKeyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_KMKL_CECKey,
            this._column_KMKL_KeyboardKey,
            this._column_KMKL_KeyboardShift,
            this._column_KMKL_KeyboardAlt,
            this._column_KMKL_KeyboardControl});
            this._lstKeyMapKeyList.FullRowSelect = true;
            this._lstKeyMapKeyList.Location = new System.Drawing.Point(218, 6);
            this._lstKeyMapKeyList.Name = "_lstKeyMapKeyList";
            this._lstKeyMapKeyList.Size = new System.Drawing.Size(867, 150);
            this._lstKeyMapKeyList.TabIndex = 1;
            this._lstKeyMapKeyList.UseCompatibleStateImageBehavior = false;
            this._lstKeyMapKeyList.View = System.Windows.Forms.View.Details;
            this._lstKeyMapKeyList.SelectionChanged += new System.EventHandler(this._lstKeyMapKeyList_SelectionChanged);
            // 
            // _column_KMKL_CECKey
            // 
            this._column_KMKL_CECKey.Groupable = false;
            this._column_KMKL_CECKey.IsEditable = false;
            this._column_KMKL_CECKey.Text = "CEC key";
            this._column_KMKL_CECKey.ToolTipText = "The name of the process";
            this._column_KMKL_CECKey.Width = 150;
            // 
            // _column_KMKL_KeyboardKey
            // 
            this._column_KMKL_KeyboardKey.Text = "Keyboard key";
            this._column_KMKL_KeyboardKey.Width = 150;
            // 
            // _column_KMKL_KeyboardShift
            // 
            this._column_KMKL_KeyboardShift.CheckBoxes = true;
            this._column_KMKL_KeyboardShift.Groupable = false;
            this._column_KMKL_KeyboardShift.IsEditable = false;
            this._column_KMKL_KeyboardShift.Text = "Shift";
            this._column_KMKL_KeyboardShift.Width = 50;
            // 
            // _column_KMKL_KeyboardAlt
            // 
            this._column_KMKL_KeyboardAlt.Text = "ALT";
            this._column_KMKL_KeyboardAlt.Width = 50;
            // 
            // _column_KMKL_KeyboardControl
            // 
            this._column_KMKL_KeyboardControl.Groupable = false;
            this._column_KMKL_KeyboardControl.IsEditable = false;
            this._column_KMKL_KeyboardControl.Text = "CTRL";
            this._column_KMKL_KeyboardControl.Width = 50;
            // 
            // _lstProcessView
            // 
            this._lstProcessView.AllColumns.Add(this._columnProcessName);
            this._lstProcessView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._columnProcessName});
            this._lstProcessView.FullRowSelect = true;
            this._lstProcessView.Location = new System.Drawing.Point(8, 6);
            this._lstProcessView.Name = "_lstProcessView";
            this._lstProcessView.Size = new System.Drawing.Size(204, 306);
            this._lstProcessView.TabIndex = 0;
            this._lstProcessView.UseCompatibleStateImageBehavior = false;
            this._lstProcessView.View = System.Windows.Forms.View.Details;
            this._lstProcessView.SelectionChanged += new System.EventHandler(this._lstProcessView_SelectionChanged);
            // 
            // _columnProcessName
            // 
            this._columnProcessName.AspectName = "ProcessName";
            this._columnProcessName.FillsFreeSpace = true;
            this._columnProcessName.Groupable = false;
            this._columnProcessName.IsEditable = false;
            this._columnProcessName.Text = "Process name";
            this._columnProcessName.ToolTipText = "The name of the process";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(1101, 380);
            this.Controls.Add(this._tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDMI CEC keyboard mapper - Configuration";
            this._tabControl.ResumeLayout(false);
            this._tabPageLibCEC.ResumeLayout(false);
            this._tabPageLibCEC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictLogo)).EndInit();
            this._tabKeyMapping.ResumeLayout(false);
            this._tabKeyMapping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapMakroList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapKeyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstProcessView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPageLibCEC;
        private System.Windows.Forms.TabPage _tabKeyMapping;
        private System.Windows.Forms.Label _lblInformation;
        private System.Windows.Forms.Label _lblDeviceType;
        private System.Windows.Forms.ComboBox _cmbDeviceType;
        private System.Windows.Forms.TextBox _txtDeviceName;
        private System.Windows.Forms.Label _lblDeviceName;
        private System.Windows.Forms.Label _lblConnectionTimeout;
        private System.Windows.Forms.TextBox _txtConnectionTimeout;
        private System.Windows.Forms.Label _lblVendorId;
        private System.Windows.Forms.Label _lblLogLevel;
        private System.Windows.Forms.ComboBox _cmbVendorId;
        private System.Windows.Forms.ComboBox _cmbLogLevel;
        private System.Windows.Forms.Label _lblBaseDevice;
        private System.Windows.Forms.ComboBox _cmbBaseDevice;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.TextBox _txtHDMI_Port;
        private System.Windows.Forms.Label _lblHDMI_Port;
        private System.Windows.Forms.PictureBox _pictLogo;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnSafe;
        private BrightIdeasSoftware.ObjectListView _lstKeyMapMakroList;
        private BrightIdeasSoftware.OLVColumn _column_KMML_CECKey;
        private BrightIdeasSoftware.OLVColumn _column_KMML_MakroApp;
        private BrightIdeasSoftware.OLVColumn _column_KMML_MakroArgs;
        private BrightIdeasSoftware.OLVColumn _column_KMML_NoWinow;
        private BrightIdeasSoftware.OLVColumn _column_KMML_WindowStyle;
        private BrightIdeasSoftware.ObjectListView _lstKeyMapKeyList;
        private BrightIdeasSoftware.OLVColumn _column_KMKL_CECKey;
        private BrightIdeasSoftware.OLVColumn _column_KMKL_KeyboardKey;
        private BrightIdeasSoftware.OLVColumn _column_KMKL_KeyboardShift;
        private BrightIdeasSoftware.OLVColumn _column_KMKL_KeyboardAlt;
        private BrightIdeasSoftware.OLVColumn _column_KMKL_KeyboardControl;
        private BrightIdeasSoftware.ObjectListView _lstProcessView;
        private BrightIdeasSoftware.OLVColumn _columnProcessName;
        private System.Windows.Forms.Button _btnKeyMapDelete;
        private System.Windows.Forms.Button _btnKeyMapAdd;
        private System.Windows.Forms.Button _btnProcessDelete;
        private System.Windows.Forms.Button _btnProcessAdd;
        private System.Windows.Forms.Label _lblInfo;
    }
}