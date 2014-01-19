namespace billy_boy.CEC_Mapper
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeigeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartHDMIReceiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _notifyIcon
            // 
            this._notifyIcon.ContextMenuStrip = this._contextMenu;
            this._notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_notifyIcon.Icon")));
            this._notifyIcon.Text = "HDMI CEC keyboard mapper";
            this._notifyIcon.Visible = true;
            // 
            // _contextMenu
            // 
            this._contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.konfigurationToolStripMenuItem,
            this.reloadConfigurationToolStripMenuItem,
            this.restartHDMIReceiverToolStripMenuItem,
            this.zeigeLogToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this._contextMenu.Name = "_contextMenu";
            this._contextMenu.Size = new System.Drawing.Size(189, 158);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.controlToolStripMenuItem.Text = "C&ontrol";
            this.controlToolStripMenuItem.Click += new System.EventHandler(this.controlToolStripMenuItem_Click);
            // 
            // konfigurationToolStripMenuItem
            // 
            this.konfigurationToolStripMenuItem.Name = "konfigurationToolStripMenuItem";
            this.konfigurationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.konfigurationToolStripMenuItem.Text = "&Configuration";
            this.konfigurationToolStripMenuItem.Click += new System.EventHandler(this.konfigurationToolStripMenuItem_Click);
            // 
            // zeigeLogToolStripMenuItem
            // 
            this.zeigeLogToolStripMenuItem.Name = "zeigeLogToolStripMenuItem";
            this.zeigeLogToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.zeigeLogToolStripMenuItem.Text = "Show &log";
            this.zeigeLogToolStripMenuItem.Click += new System.EventHandler(this.zeigeLogToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.beendenToolStripMenuItem.Text = "&Shutdown";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // reloadConfigurationToolStripMenuItem
            // 
            this.reloadConfigurationToolStripMenuItem.Name = "reloadConfigurationToolStripMenuItem";
            this.reloadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reloadConfigurationToolStripMenuItem.Text = "&Reload configuration";
            this.reloadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.reloadConfigurationToolStripMenuItem_Click);
            // 
            // restartHDMIReceiverToolStripMenuItem
            // 
            this.restartHDMIReceiverToolStripMenuItem.Name = "restartHDMIReceiverToolStripMenuItem";
            this.restartHDMIReceiverToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.restartHDMIReceiverToolStripMenuItem.Text = "R&estart HDMI receiver";
            this.restartHDMIReceiverToolStripMenuItem.Click += new System.EventHandler(this.restartHDMIReceiverToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 166);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "HDMI CEC to keyboard mapper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this._contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ContextMenuStrip _contextMenu;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeigeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartHDMIReceiverToolStripMenuItem;
    }
}