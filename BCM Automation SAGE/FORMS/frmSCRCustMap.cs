using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BCM_Automation_SAGE.MODULES.CommonFunctions;

namespace BCM_Automation_SAGE.FORMS
{
    public partial class frmSCRCustMap : Form
    {
        string SQL;
        DataTable DT;
        frmError error = new frmError();
        int CustID = 0;
        public frmSCRCustMap()
        {
            InitializeComponent();
        }

        private void frmSCRCustMap_Load(object sender, EventArgs e)
        {
            loadCustomers();           
        }

        private void loadCustomers()
        {
            SQL = "SELECT DCLink, [Name] FROM client";
            LoadCombo(SQL, cboCust, "DCLink", "Name", true, false);
            cboCust.SelectedIndex = -1;
        }

        private void loadScrMapping()
        {
            if(cboCust.SelectedIndex != -1)
            {
                SQL = "SELECT m.CustID,c.[Name] [Cust Name],M.[RebatePerCase] [Per Case] ,M.[RebatePercent] [Percentage] FROM [dbo].[WIZ_BMCL_SCR_MAPPING] M INNER JOIN Client C ON M.CustID = C.DCLink WHERE M.CustID = " + cboCust.SelectedValue;
                LoadDataGrid(dgScrMapping, SQL, "CustID", "");
                dgScrMapping.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            
        }

        private void txtPerCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void TextBox_KeyDown(System.Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }


        private void txtPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveScrMapping_Click(object sender, EventArgs e)
        {
            //Check if customer has been selected
            if (cboCust.SelectedIndex == -1)
            {
                MessageBox.Show("Kindly select a customer", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCust.Focus();
                return;
            }
            //Validate only one input either per case or percentage
            if (txtPerCase.Text.Length > 0 && txtPercentage.Text.Length > 0)
            {
                MessageBox.Show("Kindly populate only one field, either Per Case or Percentage", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CustID == 0)
            {
                //Check if customer SCR mapping exists
                SQL = "IF Exists (SELECT * FROM [dbo].[WIZ_BMCL_SCR_MAPPING] WHERE CustID = " + cboCust.SelectedValue + ") SELECT 1 ELSE SELECT 0";
                bool custExists = FetchSingleBooleanValue(SQL);

                if (custExists)
                {
                    MessageBox.Show("Mapping for "+ cboCust.Text +" already exists ", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    saveNewScrMapping();
                }

               
            }
            else
            {
                editScrMapping();
            }            
        }

        private void saveNewScrMapping()
        {
            try
            {  
                int PerCase = (String.IsNullOrEmpty(txtPerCase.Text)) ? 0 : Convert.ToInt32(txtPerCase.Text);

                int Percentage = (String.IsNullOrEmpty(txtPercentage.Text)) ? 0 : Convert.ToInt32(txtPercentage.Text);

                SQL = "INSERT INTO [dbo].[WIZ_BMCL_SCR_MAPPING] ([CustID],[RebatePerCase] ,[RebatePercent]) VALUES (" + Convert.ToInt64(cboCust.SelectedValue) + "," + PerCase + "," + Percentage + ")";

                if (ExecuteQuery(SQL))
                {
                    MessageBox.Show("Record saved successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeControls();
                    loadScrMapping();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }

        private void editScrMapping()
        {
            try
            {

                int PerCase = (String.IsNullOrEmpty(txtPerCase.Text)) ? 0 : Convert.ToInt32(txtPerCase.Text);

                int Percentage = (String.IsNullOrEmpty(txtPercentage.Text)) ? 0 : Convert.ToInt32(txtPercentage.Text);

                SQL = "UPDATE [dbo].[WIZ_BMCL_SCR_MAPPING] SET [RebatePerCase] ="+ PerCase + ",[RebatePercent]="+ Percentage +" WHERE CUSTID=" + CustID;

                if (ExecuteQuery(SQL))
                {
                    MessageBox.Show("Record updated successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeControls();
                    loadScrMapping();
                    CustID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }

        private void InitializeControls()
        {
            //cboCust.SelectedIndex = -1;
            txtPerCase.Text = string.Empty;
            txtPercentage.Text = string.Empty;
        }

        private void dgScrMapping_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (dgScrMapping.RowCount == 0)
            {
                return;
            }

            if (dgScrMapping.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgScrMapping.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgScrMapping.Rows[selectedrowindex];
                CustID = Convert.ToInt32(selectedRow.Cells["CustID"].Value);

                cboCust.SelectedValue = CustID;

                double PerCase = Convert.ToDouble(selectedRow.Cells["Per Case"].Value);

                double Percentage = Convert.ToDouble(selectedRow.Cells["Percentage"].Value);

                txtPerCase.Text = (PerCase == 0) ? "" : PerCase.ToString();
                txtPercentage.Text = (Percentage == 0) ? "" : Percentage.ToString();

            }
        }

        private void btnDeleteScrMapping_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgScrMapping.RowCount == 0)
                {
                    return;
                }

                if (dgScrMapping.SelectedCells.Count > 0)
                {
                    string message = "Do you want to delete this record ?";
                    string title = "Delete record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        int selectedrowindex = dgScrMapping.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dgScrMapping.Rows[selectedrowindex];

                        SQL = "DELETE FROM [dbo].[WIZ_BMCL_SCR_MAPPING] WHERE CUSTID=" + Convert.ToInt32(selectedRow.Cells["CustID"].Value);

                        if (ExecuteQuery(SQL))
                        {
                            MessageBox.Show("Record deleted successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InitializeControls();
                            loadScrMapping();
                            CustID = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP4PCustMapping frm = new frmP4PCustMapping();
            frm.Show();
        }

        private void cboCust_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadScrMapping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP4PCustKPI frm = new frmP4PCustKPI();
            frm.Show();
        }
    }
}
