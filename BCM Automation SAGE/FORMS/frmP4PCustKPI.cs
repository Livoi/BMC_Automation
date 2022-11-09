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
    public partial class frmP4PCustKPI : Form
    {
        string SQL;
        DataTable DT;
        frmError error = new frmError();
        int CustID, SNo = 0;

        public frmP4PCustKPI()
        {
            InitializeComponent();
        }

        private void frmP4PCustKPI_Load(object sender, EventArgs e)
        {
            loadCustomers();            
            loadYears();
            loadKPI();
            loadP4PRebatesSlab();
        }

        private void loadCustomers()
        {
            SQL = "SELECT DCLink, [Name] FROM client";
            LoadCombo(SQL, cboCust, "DCLink", "Name", true, false);
            cboCust.SelectedIndex = -1;
        }

        private void loadYears()
        {
            cboYear.Items.Clear();
            for (int i = 2015; i <= DateTime.Today.Year + 10; i++)
            {
                cboYear.Items.Add(i);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCust.SelectedIndex == -1)
            {
                MessageBox.Show("Kindly select a customer", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCust.Focus();
                return;
            }

            //Validate the quarters
            if (txtQtr1.Text.Length == 0 && txtQtr2.Text.Length == 0 && txtQtr3.Text.Length == 0 && txtQtr4.Text.Length == 0)
            {
                MessageBox.Show("Kindly captuire atleast one quarter.", "P4P Cust KPI Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CustID == 0)
            {
                saveNewKPI();
            }
            else
            {
                editKPI();
            }                  

        }

        private void saveNewKPI()
        {
            try
            {
                int Qtr1 = (String.IsNullOrEmpty(txtQtr1.Text)) ? 0 : Convert.ToInt32(txtQtr1.Text);

                int Qtr2 = (String.IsNullOrEmpty(txtQtr2.Text)) ? 0 : Convert.ToInt32(txtQtr2.Text);

                int Qtr3 = (String.IsNullOrEmpty(txtQtr3.Text)) ? 0 : Convert.ToInt32(txtQtr3.Text);

                int Qtr4 = (String.IsNullOrEmpty(txtQtr4.Text)) ? 0 : Convert.ToInt32(txtQtr4.Text);

                SQL = "INSERT INTO [dbo].WIZ_BMCL_P4P_KPI (CustID, P4PYear, Qtr1KPI, Qtr2KPI, Qtr3KPI, Qtr4KPI) VALUES(" + Convert.ToInt64(cboCust.SelectedValue) + "," + cboYear.Text + "," + Qtr1 + "," + Qtr2 + "," + Qtr3 + "," + Qtr4 + ")";

                if (ExecuteQuery(SQL))
                {
                    MessageBox.Show("Record saved successfully.", "P4P Cust KPI Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeControls();
                    loadKPI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "P4P Cust KPI Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }
        private void editKPI()
        {
            try
            {
                int Qtr1 = (String.IsNullOrEmpty(txtQtr1.Text)) ? 0 : Convert.ToInt32(txtQtr1.Text);

                int Qtr2 = (String.IsNullOrEmpty(txtQtr2.Text)) ? 0 : Convert.ToInt32(txtQtr2.Text);

                int Qtr3 = (String.IsNullOrEmpty(txtQtr3.Text)) ? 0 : Convert.ToInt32(txtQtr3.Text);

                int Qtr4 = (String.IsNullOrEmpty(txtQtr4.Text)) ? 0 : Convert.ToInt32(txtQtr4.Text);

                SQL = "UPDATE [dbo].WIZ_BMCL_P4P_KPI SET P4PYear=" + Convert.ToInt32(cboYear.Text) + ",Qtr1KPI=" + Qtr1 + ", Qtr2KPI=" + Qtr2 + ", Qtr3KPI=" + Qtr3 + ", Qtr4KPI="+ Qtr4+ " WHERE CustID=" + CustID;  

                if (ExecuteQuery(SQL))
                {
                    MessageBox.Show("Record saved successfully.", "P4P Cust KPI Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InitializeControls();
                    loadKPI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "P4P Cust KPI Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }


        private void InitializeControls()
        {
            cboCust.SelectedIndex = -1;
            cboYear.SelectedIndex = -1;
            txtQtr1.Text = string.Empty;
            txtQtr2.Text = string.Empty;
            txtQtr3.Text = string.Empty;
            txtQtr4.Text = string.Empty;          
        }

        private void initializeRebateControls()
        {
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtRebatePerCase.Text = string.Empty;
        }


        private void loadKPI()
        {
            if (cboCust.SelectedIndex != -1)
            {
                SQL = "SELECT K.CustId, C.[Name] [Cust Name], K.P4PYear, K.Qtr1KPI, K.Qtr2KPI, K.Qtr3KPI, K.Qtr4KPI FROM [dbo].WIZ_BMCL_P4P_KPI K INNER JOIN client C ON c.DCLink = K.CustID WHERE K.CustID = " + cboCust.SelectedValue;
                LoadDataGrid(dgKPI, SQL, "CustID", "");
                dgKPI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            
        }

        private void txtQtr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender, e);
        }

        private void txtQtr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender, e);
        }

        private void txtQtr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender, e);
        }

        private void txtQtr4_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender, e);
        }

        private void numericTxtFields(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgKPI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgKPI.Rows.Count > 0)
            {
                int selectedrowindex = dgKPI.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgKPI.Rows[selectedrowindex];
                CustID = Convert.ToInt32(selectedRow.Cells["CustID"].Value);

                cboCust.SelectedValue = CustID;

                int P4PYear = Convert.ToInt32(selectedRow.Cells["P4PYear"].Value);

                double Qtr1 = Convert.ToDouble(selectedRow.Cells["Qtr1KPI"].Value);

                double Qtr2 = Convert.ToDouble(selectedRow.Cells["Qtr2KPI"].Value);

                double Qtr3 = Convert.ToDouble(selectedRow.Cells["Qtr3KPI"].Value);

                double Qtr4 = Convert.ToDouble(selectedRow.Cells["Qtr4KPI"].Value);

                cboYear.Text = P4PYear.ToString();
                txtQtr1.Text = (Qtr1 == 0) ? "" : Qtr1.ToString();
                txtQtr2.Text = (Qtr2 == 0) ? "" : Qtr2.ToString();
                txtQtr3.Text = (Qtr3 == 0) ? "" : Qtr3.ToString();
                txtQtr4.Text = (Qtr4 == 0) ? "" : Qtr4.ToString();
            }            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgKPI.RowCount == 0)
                {
                    return;
                }

                if (dgKPI.SelectedCells.Count > 0)
                {
                    string message = "Do you want to delete this record ?";
                    string title = "Delete record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        int selectedrowindex = dgKPI.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dgKPI.Rows[selectedrowindex];

                        SQL = "DELETE FROM [dbo].[WIZ_BMCL_P4P_KPI] WHERE CUSTID=" + Convert.ToInt32(selectedRow.Cells["CustID"].Value);

                        if (ExecuteQuery(SQL))
                        {
                            MessageBox.Show("Record deleted successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InitializeControls();
                            loadKPI();
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

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender,e);
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender, e);
        }

        private void txtRebatePerCase_KeyPress(object sender, KeyPressEventArgs e)
        {
            numericTxtFields(sender, e);
        }

        private void cmdSaveRebate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom.Text.Length == 0)
                {
                    MessageBox.Show("Kindly capture from field", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtTo.Text.Length == 0)
                {
                    MessageBox.Show("Kindly capture to field", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtRebatePerCase.Text.Length == 0)
                {
                    MessageBox.Show("Kindly capture rebate per case field", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int CasesFrom = Convert.ToInt32(txtFrom.Text);
                int CasesTo = Convert.ToInt32(txtTo.Text);
                float RebatePerCase = Convert.ToInt32(txtRebatePerCase.Text);

                if (SNo == 0)
                {
                    SQL = "INSERT INTO dbo.WIZ_BMCL_P4P_REBATES_SLABS (CasesFrom, CasesTo, RebatePerCase) VALUES (" + CasesFrom + ", " + CasesTo + ", " + RebatePerCase + ")";

                    if (ExecuteQuery(SQL))
                    {
                        MessageBox.Show("Record saved successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initializeRebateControls();
                        loadP4PRebatesSlab();
                    }
                }
                else
                {
                    SQL = "UPDATE dbo.WIZ_BMCL_P4P_REBATES_SLABS SET CasesFrom=" + CasesFrom + ", CasesTo=" + CasesTo + ", RebatePerCase=" + RebatePerCase + " WHERE SNo=" + SNo;

                    if (ExecuteQuery(SQL))
                    {
                        MessageBox.Show("Record updated successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SNo = 0;
                        initializeRebateControls();
                        loadP4PRebatesSlab();
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

        private void loadP4PRebatesSlab()
        {
            SQL = "SELECT SNo, CasesFrom, CasesTo, RebatePerCase FROM dbo.WIZ_BMCL_P4P_REBATES_SLABS";
            LoadDataGrid(dgRebate, SQL, "SNo", "");
            dgRebate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmdDelRebate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgRebate.RowCount == 0)
                {
                    return;
                }

                if (dgRebate.SelectedCells.Count > 0)
                {
                    string message = "Do you want to delete this record ?";
                    string title = "Delete record";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        int selectedrowindex = dgRebate.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dgRebate.Rows[selectedrowindex];

                        SQL = "DELETE FROM [dbo].WIZ_BMCL_P4P_REBATES_SLABS WHERE SNo=" + Convert.ToInt32(selectedRow.Cells["SNo"].Value);

                        if (ExecuteQuery(SQL))
                        {
                            MessageBox.Show("Record deleted successfully.", "SCR Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            initializeRebateControls();
                            loadP4PRebatesSlab();
                            SNo = 0;
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

        private void cboCust_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadKPI();
        }

        private void dgRebate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRebate.Rows.Count > 0)
            {
                int selectedrowindex = dgRebate.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgRebate.Rows[selectedrowindex];
                SNo = Convert.ToInt32(selectedRow.Cells["SNo"].Value);             

                txtFrom.Text = selectedRow.Cells["CasesFrom"].Value.ToString();
                txtTo.Text = selectedRow.Cells["CasesTo"].Value.ToString();
                txtRebatePerCase.Text = selectedRow.Cells["RebatePerCase"].Value.ToString();
            }
        }
    }
}
