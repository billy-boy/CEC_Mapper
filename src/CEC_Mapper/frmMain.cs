﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Mapper
{
    public partial class frmMain : Form
    {
        public frmConfig _configFrm = null;
        public frmControl _controlFrm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Visible = false; // Hide form window.
            ShowInTaskbar = false; // Remove from taskbar.

            base.OnLoad(e);
        }

        private void OnExit(object sender, EventArgs e)
        {
            CEC_MapperThread.getInstance().Stop();
            Application.Exit();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEC_MapperThread.getInstance().Stop();
            this.Close();
        }

        private void zeigeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"Log.txt")))
            {
                Process.Start(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"Log.txt"));
            }
            else
            {
                MessageBox.Show("Es konnte kein Log gefunden werden. Wurde eines aktiviert?", "HDMI CEC Mapper Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void konfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_configFrm != null && _configFrm.IsDisposed)
                _configFrm = null;

            if (_configFrm == null)
            {
                _configFrm = new frmConfig();
                _configFrm.Show();
            }
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_controlFrm != null && _controlFrm.IsDisposed)
                _controlFrm = null;

            if (_controlFrm == null)
            {
                _controlFrm = new frmControl();
                _controlFrm.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_configFrm != null && _configFrm.IsDisposed)
                _configFrm = null;
            else if (_configFrm != null)
                _configFrm.Close();
        
            if (_controlFrm != null && _controlFrm.IsDisposed)
                _controlFrm = null;
            else if (_controlFrm != null)
                _controlFrm.Close();
        }

        private void reloadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEC_MapperThread.getInstance().Mapper.ReInit();
        }

        private void restartHDMIReceiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEC_MapperThread.getInstance().Stop();
            CEC_MapperThread.getInstance().Start();
        }
    }

}
