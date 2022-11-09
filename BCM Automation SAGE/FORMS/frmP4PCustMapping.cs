using Pastel.Evolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BCM_Automation_SAGE.MODULES.CommonFunctions;


namespace BCM_Automation_SAGE.FORMS
{
    public partial class frmP4PCustMapping : Form
    {
        string SQL, QueryFilter;
        DataTable DT;
        frmError error = new frmError();
        int CustID, SNo, GLAccount, TaxRate = 0;
        double QtyTotal = 0;

        public frmP4PCustMapping()
        {
            InitializeComponent();
           
        }

        private void frmP4PCustMapping_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSettings();
                DatabaseContext.CreateCommonDBConnection(ConnCOMM);
                DatabaseContext.SetLicense("DE12111058", "2523370");
                DatabaseContext.CreateConnection(ConnSAGE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
                return;
            }

            loadCustomers();
            //loadCustKPI();
        }

        private void optQ1_CheckedChanged(object sender, EventArgs e)
        {
            if (optQ1.Checked)
            {
                txtQ1.Text = loadTargetsPerQtr(1, dtEnd.Value.Year, Convert.ToInt32(cboCust.SelectedValue)).ToString();

                if (QtyTotal >= Convert.ToDouble(txtQ1.Text)) txtQtyAboveTarget.Text = QtyTotal.ToString("n2");                 txtQtyAboveTarget.Text = (QtyTotal - Convert.ToDouble(txtQ1.Text)).ToString("n2");
            }

        }

        private void loadCustomers()
        {
            SQL = "SELECT DCLink, [Name] FROM client";
            LoadCombo(SQL, cboCust, "DCLink", "Name", true, false);
            cboCust.SelectedIndex = -1;
        }

        private void optQ2_CheckedChanged(object sender, EventArgs e)
        {

            if (optQ2.Checked)
            {
                txtQ2.Text = loadTargetsPerQtr(2, dtEnd.Value.Year, Convert.ToInt32(cboCust.SelectedValue)).ToString();

                txtQtyAboveTarget.Text = (QtyTotal - Convert.ToDouble(txtQ2.Text)).ToString("n2");
            }

        }

        private void optQ3_CheckedChanged(object sender, EventArgs e)
        {

            if (optQ3.Checked)
            {
                txtQ3.Text = loadTargetsPerQtr(3, dtEnd.Value.Year, Convert.ToInt32(cboCust.SelectedValue)).ToString();

                txtQtyAboveTarget.Text = (QtyTotal - Convert.ToDouble(txtQ3.Text)).ToString("n2");
            }


        }

        private void optQ4_CheckedChanged(object sender, EventArgs e)
        {
            if (optQ4.Checked)
            {
                txtQ4.Text = loadTargetsPerQtr(4, dtEnd.Value.Year, Convert.ToInt32(cboCust.SelectedValue)).ToString();

                txtQtyAboveTarget.Text = (QtyTotal - Convert.ToDouble(txtQ4.Text)).ToString("n2");
            }


        }

        private int loadTargetsPerQtr(int Qtr, int year, int CustID)
        {
            if (cboCust.SelectedIndex == -1)
            {
                MessageBox.Show("Kindly select a customer", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCust.Focus();
                return 0;
            }

            string column = string.Empty;
            switch (Qtr)
            {
                case 1:
                    // code block
                    column = "Qtr1KPI";
                    break;
                case 2:
                    // code block
                    column = "Qtr2KPI";
                    break;
                case 3:
                    // code block
                    column = "Qtr3KPI";
                    break;
                case 4:
                    // code block
                    column = "Qtr4KPI";
                    break;
            }
            SQL = "SELECT " + column + " FROM [dbo].[WIZ_BMCL_P4P_KPI] WHERE CustID =" + CustID + " AND P4PYear=" + year;
            int KPIValue = FetchSingleIntValue(SQL, true, false);

            return KPIValue;
        }

        private void cboCust_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadCustKPI();
        }

        private void dgKPI_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgKPI.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }           
        }

        private void dgKPI_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgKPI.IsCurrentCellDirty)
            {
                dgKPI.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }

        private void dgKPI_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double P4PAmountTotal = 0;
            if (dgKPI.Columns[e.ColumnIndex].Name == "chk" || dgKPI.Columns[e.ColumnIndex].Name == "P4P Amount")
            {

                double P4PAmount, SCRAmount, InvTotExcl = 0;

                for (int i = 0; i < dgKPI.RowCount; i++)
                {
                    P4PAmount = Convert.ToDouble((dgKPI.Rows[i].Cells["P4P Amount"].Value == "")? 0: dgKPI.Rows[i].Cells["P4P Amount"].Value);
                    SCRAmount = Convert.ToDouble(dgKPI.Rows[i].Cells["SCR Amount"].Value ?? 0);
                    InvTotExcl = Convert.ToDouble(dgKPI.Rows[i].Cells["InvTotExcl"].Value ?? 0);

                    if (Convert.ToBoolean(dgKPI.Rows[i].Cells["chk"].Value) && dgKPI.Rows[i].Cells["P4P Amount"].Value.ToString().Length > 0)
                    {
                        if(P4PAmount > 0)
                        {
                            if (validateP4PAmt(InvTotExcl, P4PAmount, SCRAmount))
                            {
                                P4PAmountTotal += P4PAmount;
                            }
                            else
                            {
                                MessageBox.Show(" P4P Amount + SCR Amount cannot be greater than The excl amount", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                dgKPI.Rows[i].Cells["P4P Amount"].Value = 0;
                                return;
                            }
                        }
                                           

                    }

                }

                txtTotalP4P.Text = P4PAmountTotal.ToString("n2");
            }
        }

        public static bool validateP4PAmt(double InvTotExcl, double P4PAmnt, double SCRAmnt)
        {
            if((P4PAmnt+ SCRAmnt) > InvTotExcl)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtQtyAboveTarget_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtQtyAboveTarget.Text) > 0)
            {
                double rebateApplicable = loadRebateApplicable();
                txtRebateApplicable.Text = rebateApplicable.ToString();
                txtTotalRebate.Text = (rebateApplicable * Convert.ToDouble(txtQtyAboveTarget.Text)).ToString("n2");
            }
            else
            {
                txtTotalRebate.Text = 0.ToString("n2");
            }

        }

        private double loadRebateApplicable()
        {
            SQL = "SELECT TOP 1 RebatePerCase FROM [dbo].[WIZ_BMCL_P4P_REBATES_SLABS] WHERE " + Convert.ToDouble(txtQtyAboveTarget.Text) + " BETWEEN CasesFrom AND CasesTo";

            return FetchDoubleValue(SQL, true, false);
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetRebate()
        {
            SQL = "SELECT TOP 1 RebatePerCase FROM [dbo].[WIZ_BMCL_P4P_REBATES_SLABS] WHERE "+Convert.ToDouble(txtQtyAboveTarget.Text)+" BETWEEN CasesFrom AND CasesTo";
            Double Rebate = FetchDoubleValue(SQL, true, false);

            txtRebateApplicable.Text = Rebate.ToString("N2");
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgKPI.RowCount > 0 && txtTotalRebate.Text !="" && Convert.ToDouble(txtTotalRebate.Text) == Convert.ToDouble(txtTotalP4P.Text))
                {
                    int y = 0;
                    for (int i = 0; i < dgKPI.RowCount; i++)
                    {
                        if (Convert.ToBoolean(dgKPI.Rows[i].Cells["chk"].Value) && dgKPI.Rows[i].Cells["P4P Amount"].Value.ToString().Length > 0)
                        {

                            int InvoiceID = Convert.ToInt32(dgKPI.Rows[i].Cells["Invoice ID"].Value);
                            double P4PRebateAmt = Convert.ToInt32(dgKPI.Rows[i].Cells["P4P Amount"].Value);

                            SQL = "INSERT INTO [dbo].[WIZ_BMCL_P4P_REBATES_APPLIED] ([InvoiceID],[P4PRebateAmt]) VALUES("+ InvoiceID + "," + P4PRebateAmt + ")";

                            if (ExecuteQuery(SQL))
                            {
                                createCreditNoteSage(InvoiceID, P4PRebateAmt);
                                y++;                                
                            }
                        }
                    }

                    MessageBox.Show("Saved " + y.ToString() + "/" + dgKPI.RowCount.ToString() + " records successfully.", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Total rebate amount is not equal to the P4P amount applied. Cannot save", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }

        private void createCreditNoteSage(int InvoiceID, double Rebate)
        {
            SQL = "select i.AccountID [Cust ID], i.AutoIndex [Invoice ID],iStockCodeID, s.Code, s.Description_1,  (l.fQtyLastProcessLineTotExcl/i.InvTotExcl) * "+ Rebate + " [Amount], (l.fQtyLastProcessLineTotIncl/i.InvTotIncl) * "+ Rebate + " from _btblInvoiceLines l inner join StkItem s on l.iStockCodeID = s.StockLink inner join InvNum i on i.AutoIndex = l.iInvoiceID where iInvoiceID =" + InvoiceID;

            DT = new DataTable();
            LoadDatatable(SQL, DT);

            if (DT.Rows.Count > 0)
            {
                int CustID, InvID, ItemCode = 0;
                string ItemName = string.Empty;
                double Amt = 0;
                foreach (DataRow r in DT.Rows)
                {

                    CustID = Convert.ToInt32(r["Cust ID"].ToString());
                    InvID = Convert.ToInt32(r["Invoice ID"].ToString());
                    Amt = Convert.ToDouble(r["Amount"].ToString());
                    ItemCode = Convert.ToInt32(r["Code"].ToString());
                    ItemName = r["Description_1"].ToString();

                    creditNote(CustID, Amt, InvID, ItemCode, ItemName);

                }
            }

        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            if (cboCust.SelectedIndex !=-1) loadCustKPI();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            if (cboCust.SelectedIndex != -1) loadCustKPI();
        }

        private void LoadSettings()
        {
            SQL = "SELECT ISNULL(GLAccountLink, 0) GLAccountLink, ISNULL(TaxRateID, 0) TaxRateID FROM WIZ_BMCL_SETTINGS";
            DataTable DT = new DataTable();
            LoadDatatable(SQL, DT);

            if (DT.Rows.Count > 0)
            {
                GLAccount = Convert.ToInt32(DT.Rows[0]["GLAccountLink"]);
                TaxRate = Convert.ToInt32(DT.Rows[0]["TaxRateID"]);
            }
        }

        private void creditNote(int CustID, Double Amt, int InvID, int ItemCode, string ItemName)
        {
            //MessageBox.Show(GLAccount.ToString());
            CreditNote CN = new CreditNote();
            CN.Customer = new Customer(CustID);
            CN.InvoiceDate = DateTime.Now;// choose to set the 

            OrderDetail OD = new OrderDetail();
         
            OD = new OrderDetail();
            //OD.UserFields["ItemCode"] = ItemCode;
            //OD.UserFields["Name"] = ItemName;
            CN.Detail.Add(OD);          
            OD.GLAccount = new GLAccount( GLAccount);//Use the GLAccount Item constructor to specify a Account
            //OD.GLAccount = new GLAccount(;//Use the 
            OD.Quantity = 1;
            OD.TaxType = new TaxRate(TaxRate);
            OD.ToProcess = OD.Quantity;
            OD.UnitSellingPrice = Amt;

            CN.Process();
        }

        private void loadCustKPI()
        {
            QueryFilter = " convert(varchar(10), I.InvDate, 112) BETWEEN '" + dtStart.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' AND '" + dtEnd.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' ";

            QtyTotal = 0;
            SQL = "SELECT i.AutoIndex [Invoice ID], i.InvNumber, i.InvDate, i.InvTotExcl, i.InvTotTax, i.InvTotIncl, SUM(l.fQtyLastProcess) [Qty], '' [P4P Amount],  CASE WHEN M.RebatePerCase > 0 THEN SUM(l.fQtyLastProcess) * M.RebatePerCase WHEN M.RebatePercent > 0 THEN  (M.RebatePercent * i.InvTotExcl)/100 END [SCR Amount] FROM InvNum i INNER JOIN _btblInvoiceLines l ON i.AutoIndex = L.iInvoiceID INNER JOIN WIZ_BMCL_SCR_MAPPING M ON I.AccountID = M.CustID  WHERE i.DocType IN(0, 4) AND i.DocState = 4 AND i.AccountID = " + cboCust.SelectedValue + " AND "+ QueryFilter + " AND i.AutoIndex NOT IN (SELECT InvoiceID FROM [dbo].[WIZ_BMCL_P4P_REBATES_APPLIED]) GROUP BY i.AutoIndex, i.InvNumber, i.InvDate, i.InvTotExcl, i.InvTotTax, i.InvTotIncl,  M.RebatePerCase,  M.RebatePercent";
            LoadDataGrid(dgKPI, SQL, "Invoice ID", "P4P Amount");

            if (dgKPI.Rows.Count > 0)
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.ValueType = typeof(bool);
                chk.Name = "chk";
                chk.ThreeState = false;
                chk.HeaderText = "Select";
                dgKPI.Columns.Insert(6, chk);

                dgKPI.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < dgKPI.RowCount; i++)
                {
                    QtyTotal += Convert.ToDouble(dgKPI.Rows[i].Cells["Qty"].Value);

                }
            }


        }
    }
}
