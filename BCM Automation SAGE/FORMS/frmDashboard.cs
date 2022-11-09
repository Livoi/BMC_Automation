using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCM_Automation_SAGE.FORMS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnSCRCustMap_Click(object sender, EventArgs e)
        {
            frmSCRCustMap frm = new frmSCRCustMap();
            frm.ShowDialog();
        }

        private void btnP4PCustMapping_Click(object sender, EventArgs e)
        {
            frmP4PCustMapping frm = new frmP4PCustMapping();
            frm.ShowDialog();
        }

        private void btnP4PCustKPI_Click(object sender, EventArgs e)
        {
            frmP4PCustKPI frm = new frmP4PCustKPI();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSCRRebateApply_Click(object sender, EventArgs e)
        {
            frmSCRRebateApply frm = new frmSCRRebateApply();
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }
    }
}
