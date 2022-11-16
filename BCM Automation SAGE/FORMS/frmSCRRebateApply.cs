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
    public partial class frmSCRRebateApply : Form
    {
        string SQL, QueryFilter;
        DataTable DT;
        frmError error = new frmError();
        int SCRGLAccount, SCRTaxRate, P4PGLAccount, P4PTaxRate = 0;
        double QtyTotal = 0;

        public frmSCRRebateApply()
        {
            InitializeComponent();
            DatabaseContext.CreateCommonDBConnection(ConnCOMM);
            DatabaseContext.SetLicense("DE12111058", "2523370");
            DatabaseContext.CreateConnection(ConnSAGE);
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            loadSCRRebate();
        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            loadSCRRebate();
        }

        private void dgSCRRebate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double P4PAmountTotal = 0;
            double ExclTotal = 0;
            double VATTotal = 0;
            double IncvTotal = 0;
            double RebateTotal = 0;
            if (dgSCRRebate.Columns[e.ColumnIndex].Name == "chk")
            {

                double P4PAmount, RebateValue, InvTotExcl, Incv, VAT = 0;

                for (int i = 0; i < dgSCRRebate.RowCount; i++)
                {
                    P4PAmount = Convert.ToDouble(dgSCRRebate.Rows[i].Cells["P4P Value"].Value);
                    RebateValue = Convert.ToDouble(dgSCRRebate.Rows[i].Cells["Rebate Value"].Value);
                    InvTotExcl = Convert.ToDouble(dgSCRRebate.Rows[i].Cells["InvTotExcl"].Value);
                    Incv = Convert.ToDouble(dgSCRRebate.Rows[i].Cells["InvTotIncl"].Value);
                    VAT = Convert.ToDouble(dgSCRRebate.Rows[i].Cells["InvTotTax"].Value);


                    if (Convert.ToBoolean(dgSCRRebate.Rows[i].Cells["chk"].Value))
                    {

                        if (frmP4PCustMapping.validateP4PAmt(InvTotExcl, P4PAmount, RebateValue))
                        {
                            P4PAmountTotal += P4PAmount;
                            ExclTotal += InvTotExcl;
                            VATTotal += VAT;
                            IncvTotal += Incv;
                            RebateTotal += RebateValue;

                        }
                        else
                        {
                            MessageBox.Show(" P4P Amount + SCR Amount cannot be greater than The excl amount", "P4P Customer Mapping Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            (dgSCRRebate.Rows[i].Cells["chk"] as DataGridViewCheckBoxCell).Value = false;

                            //dgSCRRebate_CellValueChanged(sender, e);

                            return;
                        }

                    }

                }

                txtTotExcl.Text = ExclTotal.ToString("n2");
                txtTotIncl.Text = IncvTotal.ToString("n2");
                txtTotP4P.Text = P4PAmountTotal.ToString("n2");
                txtTotRebate.Text = RebateTotal.ToString("n2");
                txtTotVAT.Text = VATTotal.ToString("n2");
            }
        }

        private void dgSCRRebate_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgSCRRebate.IsCurrentCellDirty)
            {
                dgSCRRebate.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                int y = 0;
                for (int i = 0; i < dgSCRRebate.RowCount; i++)
                {
                    if (Convert.ToBoolean(dgSCRRebate.Rows[i].Cells["chk"].Value))
                    {

                        int InvoiceID = Convert.ToInt32(dgSCRRebate.Rows[i].Cells["Invoice ID"].Value);
                        double P4PRebateAmt = Convert.ToDouble(dgSCRRebate.Rows[i].Cells["Rebate Value"].Value);

                        SQL = "INSERT INTO [dbo].[WIZ_BMCL_SCR_REBATES] ([InvID],[RebateAmt]) VALUES(" + InvoiceID + "," + P4PRebateAmt + ")";

                        if (ExecuteQuery(SQL))
                        {
                            createCreditNoteSage(InvoiceID, P4PRebateAmt);
                            y++;

                        }
                    }
                }

                MessageBox.Show("Saved " + y.ToString() + "/" + dgSCRRebate.RowCount.ToString() + " records successfully.", "SCR Rebate Apply Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred kindly contact administartor", "SCR Rebate Apply Form", MessageBoxButtons.OK, MessageBoxIcon.Error);

                error.txtError.Text = ex.ToString();
                error.ShowDialog();
            }
        }

        private void createCreditNoteSage(int InvoiceID, double Rebate)
        {
            SQL = "select i.AccountID [Cust ID], i.AutoIndex [Invoice ID],iStockCodeID, s.Code, s.Description_1,  (l.fQtyLastProcessLineTotExcl/i.InvTotExcl) * " + Rebate + " [Amount], (l.fQtyLastProcessLineTotIncl/i.InvTotIncl) * " + Rebate + " from _btblInvoiceLines l inner join StkItem s on l.iStockCodeID = s.StockLink inner join InvNum i on i.AutoIndex = l.iInvoiceID where iInvoiceID =" + InvoiceID;

            DT = new DataTable();
            LoadDatatable(SQL, DT);

            if (DT.Rows.Count > 0)
            {
                creditNote_(DT);

                //int CustID, InvID = 0;
                //string ItemName, ItemCode = string.Empty;
                //double Amt = 0;
                //foreach (DataRow r in DT.Rows)
                //{

                //    CustID = Convert.ToInt32(r["Cust ID"].ToString());
                //    InvID = Convert.ToInt32(r["Invoice ID"].ToString());
                //    Amt = Convert.ToDouble(r["Amount"].ToString());
                //    ItemCode = r["Code"].ToString();
                //    ItemName = r["Description_1"].ToString();
                //    creditNote(CustID, Amt, InvID, ItemCode, ItemName, SCRGLAccount, SCRTaxRate);

                //}
            }

        }

        private void creditNote(int CustID, Double Amt, int InvID, string ItemCode, string ItemName, int GLAccount, int TaxRate)
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
            OD.GLAccount = new GLAccount(SCRGLAccount);//Use the GLAccount Item constructor to specify a Account
            //OD.GLAccount = new GLAccount(;//Use the 
            OD.Quantity = 1;
            OD.TaxType = new TaxRate(TaxRate);
            OD.ToProcess = OD.Quantity;
            OD.UnitSellingPrice = Amt;

            CN.Process();
        }

        private void creditNote_(DataTable DT)
        {        
            CreditNote CN = new CreditNote();
            CN.Customer = new Customer((int)DT.Rows[0]["Cust ID"]);
            CN.InvoiceDate = DateTime.Now;// choose to set the 

            OrderDetail OD = new OrderDetail();
            
            foreach (DataRow r in DT.Rows)
            {
                OD = new OrderDetail();
                CN.Detail.Add(OD);
                OD.UserFields["ucIDInvTxCMItemCode"] = r["Code"].ToString();
                OD.UserFields["ucIDInvTxCMItemDesc"] = r["Description_1"].ToString();
                OD.GLAccount = new GLAccount(SCRGLAccount);
                OD.Quantity = 1;
                OD.TaxType = new TaxRate(SCRTaxRate);
                OD.ToProcess = OD.Quantity;
                OD.UnitSellingPrice = Convert.ToDouble(r["Amount"].ToString());
            }

            CN.Process();
        }

        private void LoadSettings()
        {
            SQL = "SELECT ISNULL(GLAccountLink, 0) GLAccountLink, ISNULL(TaxRateID, 0) TaxRateID, ISNULL(SCRGLAccountLink,0) SCRGLAccountLink, ISNULL(SCRTaxRateID,0) SCRTaxRateID FROM WIZ_BMCL_SETTINGS";
            DataTable DT = new DataTable();
            LoadDatatable(SQL, DT);

            if (DT.Rows.Count > 0)
            {
                SCRGLAccount = Convert.ToInt32(DT.Rows[0]["GLAccountLink"]);
                SCRTaxRate = Convert.ToInt32(DT.Rows[0]["TaxRateID"]);
            }
        }

        private void frmSCRRebateApply_Load(object sender, EventArgs e)
        {
            loadSCRRebate();
            LoadSettings();
        }
        private void loadSCRRebate()
        {
            QueryFilter = " convert(varchar(10), I.InvDate, 112) BETWEEN '" + dtStart.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' AND '" + dtEnd.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' ";

            QtyTotal = 0;
            SQL = "SELECT  C.Name [Customer],  i.AutoIndex [Invoice ID], i.InvDate [Date], i.InvNumber, i.InvTotExcl, i.InvTotTax, i.InvTotIncl, SUM(l.fQtyLastProcess) [Qty], CASE WHEN M.RebatePerCase > 0 THEN ISNULL(M.RebatePerCase,0) WHEN M.RebatePercent > 0 THEN  ISNULL(M.RebatePercent,0) ELSE 0  END [Rebate Rate], CASE WHEN ISNULL(M.RebatePerCase,0) > 0 THEN CONVERT(DECIMAL(30,2),SUM(l.fQtyLastProcess) * ((ISNULL(M.RebatePerCase,0)*100)/116)) WHEN ISNULL(M.RebatePercent,0) > 0 THEN  (ISNULL(M.RebatePercent,0) * i.InvTotExcl)/100 ELSE 0 END [Rebate Value], ISNULL(R.P4PRebateAmt,0) [P4P Value]  FROM InvNum i INNER JOIN _btblInvoiceLines l ON i.AutoIndex = L.iInvoiceID LEFT JOIN WIZ_BMCL_SCR_MAPPING M ON I.AccountID = M.CustID INNER JOIN client C ON c.DCLink = i.AccountID LEFT JOIN [dbo].[WIZ_BMCL_P4P_REBATES_APPLIED] R ON i.AutoIndex = R.InvoiceID WHERE i.DocType IN(0, 4) AND i.DocState = 4 AND i.AutoIndex NOT IN (SELECT InvID FROM [WIZ_BMCL_SCR_REBATES]) AND " + QueryFilter + " GROUP BY i.AutoIndex, i.InvNumber, i.InvDate, i.InvTotExcl, i.InvTotTax, i.InvTotIncl,  M.RebatePerCase,  M.RebatePercent, C.Name,  R.P4PRebateAmt";
            LoadDataGrid(dgSCRRebate, SQL, "Invoice ID", "Qty");

            if (dgSCRRebate.Rows.Count > 0)
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.ValueType = typeof(bool);
                chk.Name = "chk";
                chk.ThreeState = false;
                chk.HeaderText = "Apply Rebate";
                dgSCRRebate.Columns.Insert(10, chk);

                dgSCRRebate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < dgSCRRebate.RowCount; i++)
                {
                    QtyTotal += Convert.ToDouble(dgSCRRebate.Rows[i].Cells["Qty"].Value);

                }
            }


        }

    }
}
