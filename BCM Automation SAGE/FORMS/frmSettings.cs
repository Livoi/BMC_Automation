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
            LoadCombo(SQL, cboP4PGLAccounts, "AccountLink", "Description", true, false);
            cboP4PGLAccounts.SelectedIndex = -1;

            LoadCombo(SQL, cboSCRGLAccounts, "AccountLink", "Description", true, false);
            cboSCRGLAccounts.SelectedIndex = -1;
        }

        private void loadTaxRate()
        {
            SQL = "select code,Description from TaxRate";
            LoadCombo(SQL, cboP4PTaxRate, "code", "Description", true, false);
            cboP4PTaxRate.SelectedIndex = -1;

            LoadCombo(SQL, cboSCRTaxRate, "code", "Description", true, false);
            cboSCRTaxRate.SelectedIndex = -1;
        }

        private void initializeControls()
        {
            cboP4PGLAccounts.SelectedIndex = -1;
            cboP4PTaxRate.SelectedIndex = -1;
            cboSCRGLAccounts.SelectedIndex = -1;
            cboSCRTaxRate.SelectedIndex = -1;
        }

        private void LoadSettings()
        {
            SQL = "SELECT ISNULL(GLAccountLink, 0) GLAccountLink, ISNULL(TaxRateID, 0) TaxRateID, ISNULL(SCRGLAccountLink,0) SCRGLAccountLink, ISNULL(SCRTaxRateID,0) SCRTaxRateID FROM WIZ_BMCL_SETTINGS";
            DataTable DT = new DataTable();
            LoadDatatable(SQL, DT);

            if(DT.Rows.Count> 0)
            {
                cboP4PGLAccounts.SelectedValue = DT.Rows[0]["GLAccountLink"];
                cboP4PTaxRate.SelectedValue = DT.Rows[0]["TaxRateID"];
                cboSCRGLAccounts.SelectedValue = DT.Rows[0]["SCRGLAccountLink"];
                cboSCRTaxRate.SelectedValue = DT.Rows[0]["SCRTaxRateID"];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cboP4PGLAccounts.SelectedIndex != -1 && cboP4PTaxRate.SelectedIndex !=-1)
            {
                SQL = "IF NOT EXISTS (SELECT 1 FROM WIZ_BMCL_SETTINGS) BEGIN INSERT INTO WIZ_BMCL_SETTINGS(GLAccountLink, TaxRateID, SCRGLAccountLink, SCRTaxRateID) VALUES (" + cboP4PGLAccounts.SelectedValue + ","+ cboP4PTaxRate.SelectedValue + "," + cboSCRGLAccounts.SelectedValue + "," + cboSCRTaxRate.SelectedValue + ") END ELSE BEGIN UPDATE WIZ_BMCL_SETTINGS SET GLAccountLink =" + cboP4PGLAccounts.SelectedValue + " , TaxRateID=" + cboP4PTaxRate.SelectedValue + ",SCRGLAccountLink =" + cboSCRGLAccounts.SelectedValue + ",SCRTaxRateID =" + cboSCRTaxRate.SelectedValue + "  END";

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
