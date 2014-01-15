namespace billy_boy.CEC_Mapper
{
    partial class frmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControl));
            this._lblMapper = new System.Windows.Forms.Label();
            this._lblMapper_Status = new System.Windows.Forms.Label();
            this._btnMapper = new System.Windows.Forms.Button();
            this._imageListBtn = new System.Windows.Forms.ImageList(this.components);
            this._lblReceiver = new System.Windows.Forms.Label();
            this._lblAdapter = new System.Windows.Forms.Label();
            this._lblTV = new System.Windows.Forms.Label();
            this._btnReceiver = new System.Windows.Forms.Button();
            this._lblReceiver_Status = new System.Windows.Forms.Label();
            this._lblAdapter_Status = new System.Windows.Forms.Label();
            this._lblTV_Status = new System.Windows.Forms.Label();
            this._pictMapper = new System.Windows.Forms.PictureBox();
            this._lblTVInfo = new System.Windows.Forms.Label();
            this._btnTV = new System.Windows.Forms.Button();
            this._lblTVInfo_Status = new System.Windows.Forms.Label();
            this._btnHTPC = new System.Windows.Forms.Button();
            this._lblHTPC = new System.Windows.Forms.Label();
            this._lblHTPC_Status = new System.Windows.Forms.Label();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._pictReceiver = new System.Windows.Forms.PictureBox();
            this._pictAdapter = new System.Windows.Forms.PictureBox();
            this._pictTV = new System.Windows.Forms.PictureBox();
            this._pictTVInfo = new System.Windows.Forms.PictureBox();
            this._pictHTPC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictMapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictAdapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictTVInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictHTPC)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblMapper
            // 
            this._lblMapper.AutoSize = true;
            this._lblMapper.Location = new System.Drawing.Point(13, 14);
            this._lblMapper.Name = "_lblMapper";
            this._lblMapper.Size = new System.Drawing.Size(79, 13);
            this._lblMapper.TabIndex = 0;
            this._lblMapper.Text = "Mapper thread:";
            // 
            // _lblMapper_Status
            // 
            this._lblMapper_Status.AutoSize = true;
            this._lblMapper_Status.Location = new System.Drawing.Point(145, 14);
            this._lblMapper_Status.Name = "_lblMapper_Status";
            this._lblMapper_Status.Size = new System.Drawing.Size(60, 13);
            this._lblMapper_Status.TabIndex = 1;
            this._lblMapper_Status.Text = "not running";
            // 
            // _btnMapper
            // 
            this._btnMapper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMapper.ImageIndex = 2;
            this._btnMapper.ImageList = this._imageListBtn;
            this._btnMapper.Location = new System.Drawing.Point(220, 8);
            this._btnMapper.Name = "_btnMapper";
            this._btnMapper.Size = new System.Drawing.Size(97, 24);
            this._btnMapper.TabIndex = 2;
            this._btnMapper.Text = "Start";
            this._btnMapper.UseVisualStyleBackColor = true;
            this._btnMapper.Click += new System.EventHandler(this._btn_Click);
            // 
            // _imageListBtn
            // 
            this._imageListBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imageListBtn.ImageStream")));
            this._imageListBtn.TransparentColor = System.Drawing.Color.Transparent;
            this._imageListBtn.Images.SetKeyName(0, "play_16px.png");
            this._imageListBtn.Images.SetKeyName(1, "stop_16px.png");
            this._imageListBtn.Images.SetKeyName(2, "logout_16px.png");
            this._imageListBtn.Images.SetKeyName(3, "switch_16px.png");
            this._imageListBtn.Images.SetKeyName(4, "hibernate_16px.png");
            this._imageListBtn.Images.SetKeyName(5, "reboot_16px.png");
            this._imageListBtn.Images.SetKeyName(6, "suspend_16px.png");
            this._imageListBtn.Images.SetKeyName(7, "halt_16px.png");
            // 
            // _lblReceiver
            // 
            this._lblReceiver.AutoSize = true;
            this._lblReceiver.Location = new System.Drawing.Point(12, 44);
            this._lblReceiver.Name = "_lblReceiver";
            this._lblReceiver.Size = new System.Drawing.Size(86, 13);
            this._lblReceiver.TabIndex = 3;
            this._lblReceiver.Text = "Receiver thread:";
            // 
            // _lblAdapter
            // 
            this._lblAdapter.AutoSize = true;
            this._lblAdapter.Location = new System.Drawing.Point(13, 74);
            this._lblAdapter.Name = "_lblAdapter";
            this._lblAdapter.Size = new System.Drawing.Size(70, 13);
            this._lblAdapter.TabIndex = 4;
            this._lblAdapter.Text = "CEC adapter:";
            // 
            // _lblTV
            // 
            this._lblTV.AutoSize = true;
            this._lblTV.Location = new System.Drawing.Point(13, 106);
            this._lblTV.Name = "_lblTV";
            this._lblTV.Size = new System.Drawing.Size(74, 13);
            this._lblTV.TabIndex = 5;
            this._lblTV.Text = "TV CEC state:";
            // 
            // _btnReceiver
            // 
            this._btnReceiver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnReceiver.ImageIndex = 2;
            this._btnReceiver.ImageList = this._imageListBtn;
            this._btnReceiver.Location = new System.Drawing.Point(220, 38);
            this._btnReceiver.Name = "_btnReceiver";
            this._btnReceiver.Size = new System.Drawing.Size(97, 24);
            this._btnReceiver.TabIndex = 6;
            this._btnReceiver.Text = "Start";
            this._btnReceiver.UseVisualStyleBackColor = true;
            this._btnReceiver.Click += new System.EventHandler(this._btn_Click);
            // 
            // _lblReceiver_Status
            // 
            this._lblReceiver_Status.AutoSize = true;
            this._lblReceiver_Status.Location = new System.Drawing.Point(145, 44);
            this._lblReceiver_Status.Name = "_lblReceiver_Status";
            this._lblReceiver_Status.Size = new System.Drawing.Size(60, 13);
            this._lblReceiver_Status.TabIndex = 9;
            this._lblReceiver_Status.Text = "not running";
            // 
            // _lblAdapter_Status
            // 
            this._lblAdapter_Status.AutoSize = true;
            this._lblAdapter_Status.Location = new System.Drawing.Point(145, 74);
            this._lblAdapter_Status.Name = "_lblAdapter_Status";
            this._lblAdapter_Status.Size = new System.Drawing.Size(60, 13);
            this._lblAdapter_Status.TabIndex = 10;
            this._lblAdapter_Status.Text = "not running";
            // 
            // _lblTV_Status
            // 
            this._lblTV_Status.AutoSize = true;
            this._lblTV_Status.Location = new System.Drawing.Point(145, 106);
            this._lblTV_Status.Name = "_lblTV_Status";
            this._lblTV_Status.Size = new System.Drawing.Size(60, 13);
            this._lblTV_Status.TabIndex = 11;
            this._lblTV_Status.Text = "not running";
            // 
            // _pictMapper
            // 
            this._pictMapper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictMapper.Location = new System.Drawing.Point(323, 8);
            this._pictMapper.Name = "_pictMapper";
            this._pictMapper.Size = new System.Drawing.Size(24, 24);
            this._pictMapper.TabIndex = 12;
            this._pictMapper.TabStop = false;
            // 
            // _lblTVInfo
            // 
            this._lblTVInfo.AutoSize = true;
            this._lblTVInfo.Location = new System.Drawing.Point(13, 134);
            this._lblTVInfo.Name = "_lblTVInfo";
            this._lblTVInfo.Size = new System.Drawing.Size(51, 13);
            this._lblTVInfo.TabIndex = 13;
            this._lblTVInfo.Text = "TV\'s info:";
            // 
            // _btnTV
            // 
            this._btnTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnTV.ImageIndex = 4;
            this._btnTV.ImageList = this._imageListBtn;
            this._btnTV.Location = new System.Drawing.Point(220, 100);
            this._btnTV.Name = "_btnTV";
            this._btnTV.Size = new System.Drawing.Size(97, 24);
            this._btnTV.TabIndex = 16;
            this._btnTV.Text = "Wakeup";
            this._btnTV.UseVisualStyleBackColor = true;
            this._btnTV.Click += new System.EventHandler(this._btn_Click);
            // 
            // _lblTVInfo_Status
            // 
            this._lblTVInfo_Status.AutoSize = true;
            this._lblTVInfo_Status.Location = new System.Drawing.Point(145, 134);
            this._lblTVInfo_Status.Name = "_lblTVInfo_Status";
            this._lblTVInfo_Status.Size = new System.Drawing.Size(31, 13);
            this._lblTVInfo_Status.TabIndex = 17;
            this._lblTVInfo_Status.Text = "none";
            // 
            // _btnHTPC
            // 
            this._btnHTPC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnHTPC.ImageIndex = 4;
            this._btnHTPC.ImageList = this._imageListBtn;
            this._btnHTPC.Location = new System.Drawing.Point(220, 158);
            this._btnHTPC.Name = "_btnHTPC";
            this._btnHTPC.Size = new System.Drawing.Size(97, 24);
            this._btnHTPC.TabIndex = 18;
            this._btnHTPC.Text = "Activate";
            this._btnHTPC.UseVisualStyleBackColor = true;
            this._btnHTPC.Click += new System.EventHandler(this._btn_Click);
            // 
            // _lblHTPC
            // 
            this._lblHTPC.AutoSize = true;
            this._lblHTPC.Location = new System.Drawing.Point(13, 164);
            this._lblHTPC.Name = "_lblHTPC";
            this._lblHTPC.Size = new System.Drawing.Size(107, 13);
            this._lblHTPC.TabIndex = 19;
            this._lblHTPC.Text = "HTPC\'s source state:";
            // 
            // _lblHTPC_Status
            // 
            this._lblHTPC_Status.AutoSize = true;
            this._lblHTPC_Status.Location = new System.Drawing.Point(145, 164);
            this._lblHTPC_Status.Name = "_lblHTPC_Status";
            this._lblHTPC_Status.Size = new System.Drawing.Size(44, 13);
            this._lblHTPC_Status.TabIndex = 20;
            this._lblHTPC_Status.Text = "inactive";
            // 
            // _timer
            // 
            this._timer.Enabled = true;
            this._timer.Interval = 500;
            this._timer.Tick += new System.EventHandler(this._timer_Tick);
            // 
            // _pictReceiver
            // 
            this._pictReceiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictReceiver.Location = new System.Drawing.Point(323, 38);
            this._pictReceiver.Name = "_pictReceiver";
            this._pictReceiver.Size = new System.Drawing.Size(24, 24);
            this._pictReceiver.TabIndex = 21;
            this._pictReceiver.TabStop = false;
            // 
            // _pictAdapter
            // 
            this._pictAdapter.BackgroundImage = global::billy_boy.CEC_Mapper.Properties.Resources.disconnected_24px;
            this._pictAdapter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictAdapter.Location = new System.Drawing.Point(255, 69);
            this._pictAdapter.Name = "_pictAdapter";
            this._pictAdapter.Size = new System.Drawing.Size(24, 24);
            this._pictAdapter.TabIndex = 22;
            this._pictAdapter.TabStop = false;
            // 
            // _pictTV
            // 
            this._pictTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictTV.Location = new System.Drawing.Point(323, 98);
            this._pictTV.Name = "_pictTV";
            this._pictTV.Size = new System.Drawing.Size(24, 24);
            this._pictTV.TabIndex = 23;
            this._pictTV.TabStop = false;
            // 
            // _pictTVInfo
            // 
            this._pictTVInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictTVInfo.Location = new System.Drawing.Point(323, 128);
            this._pictTVInfo.Name = "_pictTVInfo";
            this._pictTVInfo.Size = new System.Drawing.Size(24, 24);
            this._pictTVInfo.TabIndex = 24;
            this._pictTVInfo.TabStop = false;
            // 
            // _pictHTPC
            // 
            this._pictHTPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._pictHTPC.Location = new System.Drawing.Point(323, 158);
            this._pictHTPC.Name = "_pictHTPC";
            this._pictHTPC.Size = new System.Drawing.Size(24, 24);
            this._pictHTPC.TabIndex = 25;
            this._pictHTPC.TabStop = false;
            // 
            // frmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 192);
            this.Controls.Add(this._pictHTPC);
            this.Controls.Add(this._pictTVInfo);
            this.Controls.Add(this._pictTV);
            this.Controls.Add(this._pictAdapter);
            this.Controls.Add(this._pictReceiver);
            this.Controls.Add(this._lblHTPC_Status);
            this.Controls.Add(this._lblHTPC);
            this.Controls.Add(this._btnHTPC);
            this.Controls.Add(this._lblTVInfo_Status);
            this.Controls.Add(this._btnTV);
            this.Controls.Add(this._lblTVInfo);
            this.Controls.Add(this._pictMapper);
            this.Controls.Add(this._lblTV_Status);
            this.Controls.Add(this._lblAdapter_Status);
            this.Controls.Add(this._lblReceiver_Status);
            this.Controls.Add(this._btnReceiver);
            this.Controls.Add(this._lblTV);
            this.Controls.Add(this._lblAdapter);
            this.Controls.Add(this._lblReceiver);
            this.Controls.Add(this._btnMapper);
            this.Controls.Add(this._lblMapper_Status);
            this.Controls.Add(this._lblMapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDMI CEC Mapper - Control";
            ((System.ComponentModel.ISupportInitialize)(this._pictMapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictAdapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictTVInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pictHTPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblMapper;
        private System.Windows.Forms.Label _lblMapper_Status;
        private System.Windows.Forms.Button _btnMapper;
        private System.Windows.Forms.Label _lblReceiver;
        private System.Windows.Forms.Label _lblAdapter;
        private System.Windows.Forms.Label _lblTV;
        private System.Windows.Forms.Button _btnReceiver;
        private System.Windows.Forms.Label _lblReceiver_Status;
        private System.Windows.Forms.Label _lblAdapter_Status;
        private System.Windows.Forms.Label _lblTV_Status;
        private System.Windows.Forms.PictureBox _pictMapper;
        private System.Windows.Forms.Label _lblTVInfo;
        private System.Windows.Forms.Button _btnTV;
        private System.Windows.Forms.Label _lblTVInfo_Status;
        private System.Windows.Forms.Button _btnHTPC;
        private System.Windows.Forms.Label _lblHTPC;
        private System.Windows.Forms.Label _lblHTPC_Status;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.PictureBox _pictReceiver;
        private System.Windows.Forms.PictureBox _pictAdapter;
        private System.Windows.Forms.PictureBox _pictTV;
        private System.Windows.Forms.PictureBox _pictTVInfo;
        private System.Windows.Forms.PictureBox _pictHTPC;
        private System.Windows.Forms.ImageList _imageListBtn;
    }
}