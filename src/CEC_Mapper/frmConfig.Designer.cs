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
            this._tabPage_LibCEC = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._rtb_libCEC_Information = new System.Windows.Forms.RichTextBox();
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
            this._tabPage_KeyMapping = new System.Windows.Forms.TabPage();
            this._pict_KML_Warning = new System.Windows.Forms.PictureBox();
            this._lbl_KML_Warning = new System.Windows.Forms.Label();
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
            this._iconList = new System.Windows.Forms.ImageList(this.components);
            this._lstKeyMapKeyList = new BrightIdeasSoftware.ObjectListView();
            this._column_KMKL_CECKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardShift = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardAlt = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._column_KMKL_KeyboardControl = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._lstProcessView = new BrightIdeasSoftware.ObjectListView();
            this._columnProcessName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._tabPage_EventMapping = new System.Windows.Forms.TabPage();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._pict_libCEC_Warning = new System.Windows.Forms.PictureBox();
            this._lbl_libCEC_Warning = new System.Windows.Forms.Label();
            this._tabControl.SuspendLayout();
            this._tabPage_LibCEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictLogo)).BeginInit();
            this._tabPage_KeyMapping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pict_KML_Warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapMakroList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapKeyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstProcessView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pict_libCEC_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPage_LibCEC);
            this._tabControl.Controls.Add(this._tabPage_KeyMapping);
            this._tabControl.Controls.Add(this._tabPage_EventMapping);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.ImageList = this._iconList;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(1101, 382);
            this._tabControl.TabIndex = 0;
            this._tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this._tabControl_Selecting);
            this._tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this._tabControl_Selected);
            this._tabControl.Enter += new System.EventHandler(this._tabControl_Enter);
            // 
            // _tabPage_LibCEC
            // 
            this._tabPage_LibCEC.Controls.Add(this._pict_libCEC_Warning);
            this._tabPage_LibCEC.Controls.Add(this._lbl_libCEC_Warning);
            this._tabPage_LibCEC.Controls.Add(this.pictureBox1);
            this._tabPage_LibCEC.Controls.Add(this._rtb_libCEC_Information);
            this._tabPage_LibCEC.Controls.Add(this._pictLogo);
            this._tabPage_LibCEC.Controls.Add(this._btnCancel);
            this._tabPage_LibCEC.Controls.Add(this._btnSafe);
            this._tabPage_LibCEC.Controls.Add(this._lblBaseDevice);
            this._tabPage_LibCEC.Controls.Add(this._cmbBaseDevice);
            this._tabPage_LibCEC.Controls.Add(this._txtHDMI_Port);
            this._tabPage_LibCEC.Controls.Add(this._lblHDMI_Port);
            this._tabPage_LibCEC.Controls.Add(this._lblVendorId);
            this._tabPage_LibCEC.Controls.Add(this._lblLogLevel);
            this._tabPage_LibCEC.Controls.Add(this._cmbVendorId);
            this._tabPage_LibCEC.Controls.Add(this._cmbLogLevel);
            this._tabPage_LibCEC.Controls.Add(this._lblConnectionTimeout);
            this._tabPage_LibCEC.Controls.Add(this._txtConnectionTimeout);
            this._tabPage_LibCEC.Controls.Add(this._txtDeviceName);
            this._tabPage_LibCEC.Controls.Add(this._lblDeviceName);
            this._tabPage_LibCEC.Controls.Add(this._cmbDeviceType);
            this._tabPage_LibCEC.Controls.Add(this._lblDeviceType);
            this._tabPage_LibCEC.ImageKey = "HDMI_16px.png";
            this._tabPage_LibCEC.Location = new System.Drawing.Point(4, 23);
            this._tabPage_LibCEC.Name = "_tabPage_LibCEC";
            this._tabPage_LibCEC.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage_LibCEC.Size = new System.Drawing.Size(1093, 355);
            this._tabPage_LibCEC.TabIndex = 0;
            this._tabPage_LibCEC.Text = "HDMI CEC";
            this._toolTip.SetToolTip(this._tabPage_LibCEC, "libCEC configuration");
            this._tabPage_LibCEC.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::billy_boy.CEC_Mapper.Properties.Resources.TV_128px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(375, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // _rtb_libCEC_Information
            // 
            this._rtb_libCEC_Information.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._rtb_libCEC_Information.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtb_libCEC_Information.Location = new System.Drawing.Point(11, 6);
            this._rtb_libCEC_Information.Name = "_rtb_libCEC_Information";
            this._rtb_libCEC_Information.Size = new System.Drawing.Size(358, 47);
            this._rtb_libCEC_Information.TabIndex = 18;
            this._rtb_libCEC_Information.Text = "On this page all settings are made, which are needed for the correct operation of" +
    " the HDMI CEC adapter via libCEC.";
            // 
            // _pictLogo
            // 
            this._pictLogo.BackgroundImage = global::billy_boy.CEC_Mapper.Properties.Resources.remote_128px;
            this._pictLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictLogo.Location = new System.Drawing.Point(375, 147);
            this._pictLogo.Name = "_pictLogo";
            this._pictLogo.Size = new System.Drawing.Size(128, 128);
            this._pictLogo.TabIndex = 17;
            this._pictLogo.TabStop = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(167, 253);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(202, 23);
            this._btnCancel.TabIndex = 16;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _btnSafe
            // 
            this._btnSafe.Location = new System.Drawing.Point(11, 253);
            this._btnSafe.Name = "_btnSafe";
            this._btnSafe.Size = new System.Drawing.Size(150, 23);
            this._btnSafe.TabIndex = 15;
            this._btnSafe.Text = "Save";
            this._btnSafe.UseVisualStyleBackColor = true;
            this._btnSafe.Click += new System.EventHandler(this._btnSafe_Click);
            // 
            // _lblBaseDevice
            // 
            this._lblBaseDevice.AutoSize = true;
            this._lblBaseDevice.Location = new System.Drawing.Point(8, 227);
            this._lblBaseDevice.Name = "_lblBaseDevice";
            this._lblBaseDevice.Size = new System.Drawing.Size(69, 13);
            this._lblBaseDevice.TabIndex = 14;
            this._lblBaseDevice.Text = "Base device:";
            // 
            // _cmbBaseDevice
            // 
            this._cmbBaseDevice.FormattingEnabled = true;
            this._cmbBaseDevice.Location = new System.Drawing.Point(167, 224);
            this._cmbBaseDevice.Name = "_cmbBaseDevice";
            this._cmbBaseDevice.Size = new System.Drawing.Size(202, 21);
            this._cmbBaseDevice.TabIndex = 13;
            this._toolTip.SetToolTip(this._cmbBaseDevice, "The HDMI CEC device to which this adapter is connected to.");
            // 
            // _txtHDMI_Port
            // 
            this._txtHDMI_Port.Location = new System.Drawing.Point(167, 198);
            this._txtHDMI_Port.Name = "_txtHDMI_Port";
            this._txtHDMI_Port.Size = new System.Drawing.Size(202, 20);
            this._txtHDMI_Port.TabIndex = 12;
            this._toolTip.SetToolTip(this._txtHDMI_Port, "The HDMI port number on which this device is connected to it\'s base device. It is" +
        " important that this information is correct!");
            // 
            // _lblHDMI_Port
            // 
            this._lblHDMI_Port.AutoSize = true;
            this._lblHDMI_Port.Location = new System.Drawing.Point(8, 201);
            this._lblHDMI_Port.Name = "_lblHDMI_Port";
            this._lblHDMI_Port.Size = new System.Drawing.Size(59, 13);
            this._lblHDMI_Port.TabIndex = 11;
            this._lblHDMI_Port.Text = "HDMI port:";
            // 
            // _lblVendorId
            // 
            this._lblVendorId.AutoSize = true;
            this._lblVendorId.Location = new System.Drawing.Point(8, 174);
            this._lblVendorId.Name = "_lblVendorId";
            this._lblVendorId.Size = new System.Drawing.Size(56, 13);
            this._lblVendorId.TabIndex = 10;
            this._lblVendorId.Text = "Vendor Id:";
            // 
            // _lblLogLevel
            // 
            this._lblLogLevel.AutoSize = true;
            this._lblLogLevel.Location = new System.Drawing.Point(8, 147);
            this._lblLogLevel.Name = "_lblLogLevel";
            this._lblLogLevel.Size = new System.Drawing.Size(73, 13);
            this._lblLogLevel.TabIndex = 9;
            this._lblLogLevel.Text = "CEC log level:";
            // 
            // _cmbVendorId
            // 
            this._cmbVendorId.FormattingEnabled = true;
            this._cmbVendorId.Location = new System.Drawing.Point(167, 171);
            this._cmbVendorId.Name = "_cmbVendorId";
            this._cmbVendorId.Size = new System.Drawing.Size(202, 21);
            this._cmbVendorId.TabIndex = 8;
            this._toolTip.SetToolTip(this._cmbVendorId, "TV\'s vendor information for CEC vendor specific communication");
            // 
            // _cmbLogLevel
            // 
            this._cmbLogLevel.FormattingEnabled = true;
            this._cmbLogLevel.Location = new System.Drawing.Point(167, 144);
            this._cmbLogLevel.Name = "_cmbLogLevel";
            this._cmbLogLevel.Size = new System.Drawing.Size(202, 21);
            this._cmbLogLevel.TabIndex = 7;
            this._toolTip.SetToolTip(this._cmbLogLevel, "Log level for the HDMI CEC adapter. Attention: If you want to see the adapter\'s l" +
        "og you have to enable application loging with debug options.");
            // 
            // _lblConnectionTimeout
            // 
            this._lblConnectionTimeout.AutoSize = true;
            this._lblConnectionTimeout.Location = new System.Drawing.Point(8, 121);
            this._lblConnectionTimeout.Name = "_lblConnectionTimeout";
            this._lblConnectionTimeout.Size = new System.Drawing.Size(101, 13);
            this._lblConnectionTimeout.TabIndex = 6;
            this._lblConnectionTimeout.Text = "Connection timeout:";
            // 
            // _txtConnectionTimeout
            // 
            this._txtConnectionTimeout.Location = new System.Drawing.Point(167, 118);
            this._txtConnectionTimeout.Name = "_txtConnectionTimeout";
            this._txtConnectionTimeout.Size = new System.Drawing.Size(202, 20);
            this._txtConnectionTimeout.TabIndex = 5;
            this._toolTip.SetToolTip(this._txtConnectionTimeout, "Timeout for connection to HDMI CEC adapter");
            // 
            // _txtDeviceName
            // 
            this._txtDeviceName.Location = new System.Drawing.Point(167, 92);
            this._txtDeviceName.Name = "_txtDeviceName";
            this._txtDeviceName.Size = new System.Drawing.Size(202, 20);
            this._txtDeviceName.TabIndex = 4;
            this._toolTip.SetToolTip(this._txtDeviceName, "The name of this device shown in all HDMI CEC components");
            // 
            // _lblDeviceName
            // 
            this._lblDeviceName.AutoSize = true;
            this._lblDeviceName.Location = new System.Drawing.Point(8, 95);
            this._lblDeviceName.Name = "_lblDeviceName";
            this._lblDeviceName.Size = new System.Drawing.Size(73, 13);
            this._lblDeviceName.TabIndex = 3;
            this._lblDeviceName.Text = "Device name:";
            // 
            // _cmbDeviceType
            // 
            this._cmbDeviceType.FormattingEnabled = true;
            this._cmbDeviceType.Location = new System.Drawing.Point(167, 65);
            this._cmbDeviceType.Name = "_cmbDeviceType";
            this._cmbDeviceType.Size = new System.Drawing.Size(202, 21);
            this._cmbDeviceType.TabIndex = 2;
            this._toolTip.SetToolTip(this._cmbDeviceType, "The HDMI CEC type of this device. Default: RecordingDevice");
            // 
            // _lblDeviceType
            // 
            this._lblDeviceType.AutoSize = true;
            this._lblDeviceType.Location = new System.Drawing.Point(8, 68);
            this._lblDeviceType.Name = "_lblDeviceType";
            this._lblDeviceType.Size = new System.Drawing.Size(67, 13);
            this._lblDeviceType.TabIndex = 1;
            this._lblDeviceType.Text = "Device type:";
            // 
            // _tabPage_KeyMapping
            // 
            this._tabPage_KeyMapping.Controls.Add(this._pict_KML_Warning);
            this._tabPage_KeyMapping.Controls.Add(this._lbl_KML_Warning);
            this._tabPage_KeyMapping.Controls.Add(this._btnKeyMapDelete);
            this._tabPage_KeyMapping.Controls.Add(this._btnKeyMapAdd);
            this._tabPage_KeyMapping.Controls.Add(this._btnProcessDelete);
            this._tabPage_KeyMapping.Controls.Add(this._btnProcessAdd);
            this._tabPage_KeyMapping.Controls.Add(this._lstKeyMapMakroList);
            this._tabPage_KeyMapping.Controls.Add(this._lstKeyMapKeyList);
            this._tabPage_KeyMapping.Controls.Add(this._lstProcessView);
            this._tabPage_KeyMapping.ImageKey = "remote_16px.png";
            this._tabPage_KeyMapping.Location = new System.Drawing.Point(4, 23);
            this._tabPage_KeyMapping.Name = "_tabPage_KeyMapping";
            this._tabPage_KeyMapping.Padding = new System.Windows.Forms.Padding(3);
            this._tabPage_KeyMapping.Size = new System.Drawing.Size(1093, 353);
            this._tabPage_KeyMapping.TabIndex = 1;
            this._tabPage_KeyMapping.Text = "Key Mapping List";
            this._toolTip.SetToolTip(this._tabPage_KeyMapping, "Maps remote control keys to keyboard keys");
            this._tabPage_KeyMapping.UseVisualStyleBackColor = true;
            // 
            // _pict_KML_Warning
            // 
            this._pict_KML_Warning.BackgroundImage = global::billy_boy.CEC_Mapper.Properties.Resources.warn_32px;
            this._pict_KML_Warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pict_KML_Warning.Location = new System.Drawing.Point(804, 315);
            this._pict_KML_Warning.Name = "_pict_KML_Warning";
            this._pict_KML_Warning.Size = new System.Drawing.Size(32, 32);
            this._pict_KML_Warning.TabIndex = 8;
            this._pict_KML_Warning.TabStop = false;
            // 
            // _lbl_KML_Warning
            // 
            this._lbl_KML_Warning.AutoSize = true;
            this._lbl_KML_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_KML_Warning.Location = new System.Drawing.Point(842, 324);
            this._lbl_KML_Warning.Name = "_lbl_KML_Warning";
            this._lbl_KML_Warning.Size = new System.Drawing.Size(243, 13);
            this._lbl_KML_Warning.TabIndex = 7;
            this._lbl_KML_Warning.Text = "Warning: Changes will happen imediately!";
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
            this._toolTip.SetToolTip(this._btnKeyMapDelete, "Delete the selected mapping");
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
            this._toolTip.SetToolTip(this._btnKeyMapAdd, "Add a new mapping to the selected process");
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
            this._toolTip.SetToolTip(this._btnProcessDelete, "Delete the selected process");
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
            this._toolTip.SetToolTip(this._btnProcessAdd, "Add a new process to communicate with");
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
            this._lstKeyMapMakroList.SmallImageList = this._iconList;
            this._lstKeyMapMakroList.TabIndex = 2;
            this._toolTip.SetToolTip(this._lstKeyMapMakroList, "List of mappings from one remote key to one macro");
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
            this._column_KMML_NoWinow.Text = "No window";
            this._column_KMML_NoWinow.Width = 94;
            // 
            // _column_KMML_WindowStyle
            // 
            this._column_KMML_WindowStyle.Groupable = false;
            this._column_KMML_WindowStyle.IsEditable = false;
            this._column_KMML_WindowStyle.Text = "Windows style";
            this._column_KMML_WindowStyle.Width = 110;
            // 
            // _iconList
            // 
            this._iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_iconList.ImageStream")));
            this._iconList.TransparentColor = System.Drawing.Color.Transparent;
            this._iconList.Images.SetKeyName(0, "remote_16px.png");
            this._iconList.Images.SetKeyName(1, "remote_24px.png");
            this._iconList.Images.SetKeyName(2, "remote_32px.png");
            this._iconList.Images.SetKeyName(3, "remote_48px.png");
            this._iconList.Images.SetKeyName(4, "remote_64px.png");
            this._iconList.Images.SetKeyName(5, "remote_72px.png");
            this._iconList.Images.SetKeyName(6, "remote_96px.png");
            this._iconList.Images.SetKeyName(7, "remote_128px.png");
            this._iconList.Images.SetKeyName(8, "remote_256px.png");
            this._iconList.Images.SetKeyName(9, "remote_400px.png");
            this._iconList.Images.SetKeyName(10, "TV_16px.png");
            this._iconList.Images.SetKeyName(11, "TV_32px.png");
            this._iconList.Images.SetKeyName(12, "TV_64px.png");
            this._iconList.Images.SetKeyName(13, "TV_128px.png");
            this._iconList.Images.SetKeyName(14, "TV_256px.png");
            this._iconList.Images.SetKeyName(15, "HDMI_16px.png");
            this._iconList.Images.SetKeyName(16, "HDMI_24px.png");
            this._iconList.Images.SetKeyName(17, "HDMI_32px.png");
            this._iconList.Images.SetKeyName(18, "HDMI_64px.png");
            this._iconList.Images.SetKeyName(19, "HDMI_72px.png");
            this._iconList.Images.SetKeyName(20, "HDMI_128px.png");
            this._iconList.Images.SetKeyName(21, "HDMI_256px.png");
            this._iconList.Images.SetKeyName(22, "keyboard_16px.png");
            this._iconList.Images.SetKeyName(23, "keyboard_24px.png");
            this._iconList.Images.SetKeyName(24, "keyboard_32px.png");
            this._iconList.Images.SetKeyName(25, "keyboard_64px.png");
            this._iconList.Images.SetKeyName(26, "keyboard_72px.png");
            this._iconList.Images.SetKeyName(27, "keyboard_96px.png");
            this._iconList.Images.SetKeyName(28, "keyboard_128px.png");
            this._iconList.Images.SetKeyName(29, "keyboard_256px.png");
            this._iconList.Images.SetKeyName(30, "console_16px.png");
            this._iconList.Images.SetKeyName(31, "run_16px.png");
            this._iconList.Images.SetKeyName(32, "windows_16px.png");
            this._iconList.Images.SetKeyName(33, "application_form_16px.png");
            this._iconList.Images.SetKeyName(34, "warn_16px.png");
            this._iconList.Images.SetKeyName(35, "warn_24px.png");
            this._iconList.Images.SetKeyName(36, "warn_32px.png");
            this._iconList.Images.SetKeyName(37, "warn_48px.png");
            this._iconList.Images.SetKeyName(38, "warn_64px.png");
            this._iconList.Images.SetKeyName(39, "warn_128px.png");
            this._iconList.Images.SetKeyName(40, "warn_256px.png");
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
            this._lstKeyMapKeyList.SmallImageList = this._iconList;
            this._lstKeyMapKeyList.TabIndex = 1;
            this._toolTip.SetToolTip(this._lstKeyMapKeyList, "List of mappings from one remote key to one keyboard key combination");
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
            this._lstProcessView.SmallImageList = this._iconList;
            this._lstProcessView.TabIndex = 0;
            this._toolTip.SetToolTip(this._lstProcessView, "List of applications to communicate with");
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
            this._columnProcessName.Width = 150;
            // 
            // _tabPage_EventMapping
            // 
            this._tabPage_EventMapping.ImageIndex = 0;
            this._tabPage_EventMapping.Location = new System.Drawing.Point(4, 23);
            this._tabPage_EventMapping.Name = "_tabPage_EventMapping";
            this._tabPage_EventMapping.Size = new System.Drawing.Size(1093, 353);
            this._tabPage_EventMapping.TabIndex = 2;
            this._tabPage_EventMapping.Text = "Event Mapping List";
            this._toolTip.SetToolTip(this._tabPage_EventMapping, "Maps remote control events to keyboard keys");
            this._tabPage_EventMapping.UseVisualStyleBackColor = true;
            // 
            // _pict_libCEC_Warning
            // 
            this._pict_libCEC_Warning.BackgroundImage = global::billy_boy.CEC_Mapper.Properties.Resources.warn_32px;
            this._pict_libCEC_Warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pict_libCEC_Warning.Location = new System.Drawing.Point(11, 282);
            this._pict_libCEC_Warning.Name = "_pict_libCEC_Warning";
            this._pict_libCEC_Warning.Size = new System.Drawing.Size(32, 32);
            this._pict_libCEC_Warning.TabIndex = 21;
            this._pict_libCEC_Warning.TabStop = false;
            // 
            // _lbl_libCEC_Warning
            // 
            this._lbl_libCEC_Warning.AutoSize = true;
            this._lbl_libCEC_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_libCEC_Warning.Location = new System.Drawing.Point(49, 292);
            this._lbl_libCEC_Warning.Name = "_lbl_libCEC_Warning";
            this._lbl_libCEC_Warning.Size = new System.Drawing.Size(381, 13);
            this._lbl_libCEC_Warning.TabIndex = 20;
            this._lbl_libCEC_Warning.Text = "You have to restart CEC_Mapper in order to activate this settings.";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(1101, 382);
            this.Controls.Add(this._tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDMI CEC keyboard mapper - Configuration";
            this._tabControl.ResumeLayout(false);
            this._tabPage_LibCEC.ResumeLayout(false);
            this._tabPage_LibCEC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictLogo)).EndInit();
            this._tabPage_KeyMapping.ResumeLayout(false);
            this._tabPage_KeyMapping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pict_KML_Warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapMakroList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstKeyMapKeyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lstProcessView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pict_libCEC_Warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPage_LibCEC;
        private System.Windows.Forms.TabPage _tabPage_KeyMapping;
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
        private System.Windows.Forms.Label _lbl_KML_Warning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox _rtb_libCEC_Information;
        private System.Windows.Forms.ImageList _iconList;
        private System.Windows.Forms.PictureBox _pict_KML_Warning;
        private System.Windows.Forms.TabPage _tabPage_EventMapping;
        private System.Windows.Forms.PictureBox _pict_libCEC_Warning;
        private System.Windows.Forms.Label _lbl_libCEC_Warning;
    }
}