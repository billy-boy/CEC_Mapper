namespace billy_boy.CEC_Mapper
{
    partial class frmProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this._lblProcessName = new System.Windows.Forms.Label();
            this._txtProcessName = new System.Windows.Forms.TextBox();
            this._btnOk = new System.Windows.Forms.Button();
            this._rtbInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // _lblProcessName
            // 
            this._lblProcessName.AutoSize = true;
            this._lblProcessName.Location = new System.Drawing.Point(13, 13);
            this._lblProcessName.Name = "_lblProcessName";
            this._lblProcessName.Size = new System.Drawing.Size(77, 13);
            this._lblProcessName.TabIndex = 0;
            this._lblProcessName.Text = "Process name:";
            // 
            // _txtProcessName
            // 
            this._txtProcessName.Location = new System.Drawing.Point(96, 10);
            this._txtProcessName.Name = "_txtProcessName";
            this._txtProcessName.Size = new System.Drawing.Size(160, 20);
            this._txtProcessName.TabIndex = 1;
            // 
            // _btnOk
            // 
            this._btnOk.Location = new System.Drawing.Point(96, 97);
            this._btnOk.Name = "_btnOk";
            this._btnOk.Size = new System.Drawing.Size(160, 23);
            this._btnOk.TabIndex = 2;
            this._btnOk.Text = "Ok";
            this._btnOk.UseVisualStyleBackColor = true;
            this._btnOk.Click += new System.EventHandler(this._btnOk_Click);
            // 
            // _rtbInfo
            // 
            this._rtbInfo.BackColor = System.Drawing.SystemColors.Control;
            this._rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbInfo.Location = new System.Drawing.Point(16, 36);
            this._rtbInfo.Name = "_rtbInfo";
            this._rtbInfo.Size = new System.Drawing.Size(238, 55);
            this._rtbInfo.TabIndex = 4;
            this._rtbInfo.Text = "The process name could be detected via Windows TaskManager or Sysinternals Proces" +
    "sExplorer. Please use without the file extension (e.g. \"notepad\")!";
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 128);
            this.Controls.Add(this._rtbInfo);
            this.Controls.Add(this._btnOk);
            this.Controls.Add(this._txtProcessName);
            this.Controls.Add(this._lblProcessName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProcess";
            this.Text = "Add a new process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblProcessName;
        private System.Windows.Forms.TextBox _txtProcessName;
        private System.Windows.Forms.Button _btnOk;
        private System.Windows.Forms.RichTextBox _rtbInfo;
    }
}