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
    public partial class frmProcess : Form
    {
        private String _processName = "";

        public frmProcess()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void _btnOk_Click(object sender, EventArgs e)
        {
            _processName = _txtProcessName.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        public String ProcessName { get { return _processName; } }
    }
}
