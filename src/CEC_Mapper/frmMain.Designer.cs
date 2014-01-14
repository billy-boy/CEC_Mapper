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
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeigeLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.konfigurationToolStripMenuItem,
            this.zeigeLogToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this._contextMenu.Name = "_contextMenu";
            this._contextMenu.Size = new System.Drawing.Size(153, 92);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // zeigeLogToolStripMenuItem
            // 
            this.zeigeLogToolStripMenuItem.Name = "zeigeLogToolStripMenuItem";
            this.zeigeLogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zeigeLogToolStripMenuItem.Text = "Zeige Log";
            this.zeigeLogToolStripMenuItem.Click += new System.EventHandler(this.zeigeLogToolStripMenuItem_Click);
            // 
            // konfigurationToolStripMenuItem
            // 
            this.konfigurationToolStripMenuItem.Name = "konfigurationToolStripMenuItem";
            this.konfigurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.konfigurationToolStripMenuItem.Text = "Konfiguration";
            this.konfigurationToolStripMenuItem.Click += new System.EventHandler(this.konfigurationToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 166);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "HDMI CEC to keyboard mapper";
            this._contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon _notifyIcon;
        private System.Windows.Forms.ContextMenuStrip _contextMenu;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeigeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurationToolStripMenuItem;
    }
}