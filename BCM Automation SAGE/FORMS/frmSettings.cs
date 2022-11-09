using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCM_Automation_SAGE.MODULES;
using static BCM_Automation_SAGE.MODULES.CommonFunctions;

namespace BCM_Automation_SAGE.FORMS
{
    public partial class frmSettings : Form
    {
        string SQL;
        DataTable DT;
        string PwdKey = "65f02fab40f56c8e409b121965fa1d657a80d237fabacab95f9c59f8f967becb";
        string FPath = "";
        string SERVER = "";
        string User = "";
        string PWD = "";
        string PORT = "";
        string SSL = "";
        string DEFSETTING = "";

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            loadGLAccounts();
            loadTaxRate();
            LoadSettings();
        }

        private void loadGLAccounts()
        {
            SQL = "select AccountLink, Description from Accounts where ActiveAccount=1";
            LoadCombo(SQL, cboGLAccounts, "AccountLink", "Description", true, false);
            cboGLAccounts.SelectedIndex = -1;
        }

        private void loadTaxRate()
        {
            SQL = "select code,Description from TaxRate";
            LoadCombo(SQL, cboTaxRate, "code", "Description", true, false);
            cboTaxRate.SelectedIndex = -1;
        }

        private void initializeControls()
        {
            cboGLAccounts.SelectedIndex = -1;
            cboTaxRate.SelectedIndex = -1;
        }

        private void LoadSettings()
        {
            SQL = "SELECT ISNULL(GLAccountLink, 0) GLAccountLink, ISNULL(TaxRateID, 0) TaxRateID FROM WIZ_BMCL_SETTINGS";
            DataTable DT = new DataTable();
            LoadDatatable(SQL, DT);

            if(DT.Rows.Count> 0)
            {
                cboGLAccounts.SelectedValue = DT.Rows[0]["GLAccountLink"];
                cboTaxRate.SelectedValue = DT.Rows[0]["TaxRateID"];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboGLAccounts.SelectedIndex != -1 && cboTaxRate.SelectedIndex !=-1)
            {
                SQL = "IF NOT EXISTS (SELECT 1 FROM WIZ_BMCL_SETTINGS) BEGIN INSERT INTO WIZ_BMCL_SETTINGS(GLAccountLink, TaxRateID) VALUES ("+ cboGLAccounts.SelectedValue + ","+ cboTaxRate.SelectedValue + ") END ELSE BEGIN UPDATE WIZ_BMCL_SETTINGS SET GLAccountLink ="+ cboGLAccounts.SelectedValue + " , TaxRateID=" + cboTaxRate.SelectedValue + " END";

                if (ExecuteQuery(SQL)) MessageBox.Show("Record saved succesfully");

                LoadSettings();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
