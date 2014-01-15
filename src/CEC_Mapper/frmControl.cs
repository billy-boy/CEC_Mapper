using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace billy_boy.CEC_Mapper
{
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            #region Mapper
            if (CEC_MapperThread.getInstance().Running)
            {
                _lblMapper_Status.Text = "running [" + CEC_MapperThread.getInstance().ThreadId.ToString() + "]";
                _lblMapper_Status.ForeColor = Color.DarkGreen;
                _btnMapper.Text = "Stop";
                _btnMapper.ImageIndex = 7;
            }
            else
            {
                _lblMapper_Status.Text = "not running";
                _lblMapper_Status.ForeColor = Color.DarkRed;
                _btnMapper.Text = "Start";
                _btnMapper.ImageIndex = 2;
            }
            #endregion

            #region Receiver
            if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Running)
            {
                _lblReceiver_Status.Text = "running [" + CEC_MapperThread.getInstance().Mapper.ThreadId.ToString() + "]";
                _lblReceiver_Status.ForeColor = Color.DarkGreen;
                _btnReceiver.Text = "Stop";
                _btnReceiver.ImageIndex = 7;
            }
            else
            {
                _lblReceiver_Status.Text = "not running";
                _lblReceiver_Status.ForeColor = Color.DarkRed;
                _btnReceiver.Text = "Start";
                _btnReceiver.ImageIndex = 2;
            }
            #endregion

            #region Adapter
            if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Connected)
            {
                _lblAdapter_Status.Text = "connected (" + CEC_MapperThread.getInstance().Mapper.Worker.Adpater_Port + ")";
                _lblAdapter_Status.ForeColor = Color.DarkGreen;
                //_pictAdapter.BackgroundImage = Properties.Resources;
            }
            else
            {
                _lblAdapter_Status.Text = "not connected";
                _lblAdapter_Status.ForeColor = Color.DarkRed;
                //_pictAdapter.BackgroundImage = Properties.Resources.disconnected_16px;
            }
            #endregion

            #region TV
            if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null 
                && (CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.On || CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.InTransitionStandbyToOn))
            {
                _lblTV_Status.Text = "on";
                _lblTV_Status.ForeColor = Color.DarkGreen;
                _btnTV.Text = "Standby";
                _btnTV.ImageIndex = 6;
                _btnTV.Enabled = true;
            }
            else if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null 
                && (CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.Standby || CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.InTransitionOnToStandby))
            {
                _lblTV_Status.Text = "standby";
                _lblTV_Status.ForeColor = Color.DarkOrange;
                _btnTV.Text = "Wakeup";
                _btnTV.ImageIndex = 4;
                _btnTV.Enabled = true;
            }
            else
            {
                _lblTV_Status.Text = "unknown";
                _lblTV_Status.ForeColor = Color.DarkRed;
                _btnTV.Text = "Wakeup";
                _btnTV.ImageIndex = 0;
                _btnTV.Enabled = false;
            }
            #endregion

            #region TV info
            if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null
                && !(CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.Unknown))
            {
                _lblTVInfo_Status.Text = "TV: " + CEC_MapperThread.getInstance().Mapper.Worker.Receiver.getVendorId(CecSharp.CecLogicalAddress.Tv).ToString();
                if (CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.AudioSystem) != CecSharp.CecPowerStatus.Unknown)
                {
                    _lblTVInfo_Status.Text += " + AVR: " + CEC_MapperThread.getInstance().Mapper.Worker.Receiver.getVendorId(CecSharp.CecLogicalAddress.AudioSystem).ToString();
                }
                _lblTVInfo_Status.ForeColor = Color.DarkGreen;
            }
            else
            {
                _lblTVInfo_Status.Text = "unknown";
                _lblTVInfo_Status.ForeColor = Color.DarkRed;
            }
            #endregion

            #region HTPC info
            if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null
                && CEC_MapperThread.getInstance().Mapper.Worker.Receiver.IsActiveSource())
            {
                _lblHTPC_Status.Text = "active";
                _lblHTPC_Status.ForeColor = Color.DarkGreen;
                _btnHTPC.Text = "Inactivate";
                _btnHTPC.ImageIndex = 6;
                _btnHTPC.Enabled = true;
            }
            else if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null
                && !(CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.Unknown))
            {
                _lblHTPC_Status.Text = "inactive";
                _lblHTPC_Status.ForeColor = Color.DarkOrange;
                _btnHTPC.Text = "Activate";
                _btnHTPC.ImageIndex = 4;
                _btnHTPC.Enabled = true;
            }
            else
            {
                 _lblHTPC_Status.Text = "unknown";
                _lblHTPC_Status.ForeColor = Color.DarkRed;
                _btnHTPC.Text = "Activate";
                _btnHTPC.ImageIndex = 4;
                _btnHTPC.Enabled = false;
            }
            #endregion
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void _btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (sender == null) return;

            switch (btn.Name)
            {
                case "_btnMapper": if (CEC_MapperThread.getInstance().Running) CEC_MapperThread.getInstance().Stop(); else CEC_MapperThread.getInstance().Start(); break;
                case "_btnReceiver": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Running) CEC_MapperThread.getInstance().Mapper.Stop(); else if (CEC_MapperThread.getInstance().Mapper != null) CEC_MapperThread.getInstance().Mapper.Start(); break;
                case "_btnTV": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null && (CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.On || CEC_MapperThread.getInstance().Mapper.Worker.Receiver.PowerStatus(CecSharp.CecLogicalAddress.Tv) == CecSharp.CecPowerStatus.InTransitionStandbyToOn)) CEC_MapperThread.getInstance().Mapper.Worker.Receiver.StandByDevice(CecSharp.CecLogicalAddress.Tv); else if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) CEC_MapperThread.getInstance().Mapper.Worker.Receiver.WakeDevice(CecSharp.CecLogicalAddress.Tv); break;
                case "_btnHTPC": if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver.IsActiveSource()) CEC_MapperThread.getInstance().Mapper.Worker.Receiver.SetSource(false); else if (CEC_MapperThread.getInstance().Mapper != null && CEC_MapperThread.getInstance().Mapper.Worker != null && CEC_MapperThread.getInstance().Mapper.Worker.Receiver != null) CEC_MapperThread.getInstance().Mapper.Worker.Receiver.SetSource(true); break;
            }
        }
    }
}
