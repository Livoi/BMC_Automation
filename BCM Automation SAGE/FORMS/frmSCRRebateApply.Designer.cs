namespace BCM_Automation_SAGE.FORMS
{
    partial class frmSCRRebateApply
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.cmdSave = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtTotP4P = new System.Windows.Forms.TextBox();
            this.txtTotRebate = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtTotIncl = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtTotVAT = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtTotExcl = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.P4P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebateValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebateRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebatePercentPerCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebatePerCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dgSCRRebate = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSCRRebate)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd-MMM-yy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(997, 39);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(168, 20);
            this.dtEnd.TabIndex = 41;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(1247, 340);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(90, 39);
            this.cmdSave.TabIndex = 39;
            this.cmdSave.Text = "SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(601, 313);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(737, 2);
            this.Label5.TabIndex = 38;
            // 
            // txtTotP4P
            // 
            this.txtTotP4P.Location = new System.Drawing.Point(1058, 351);
            this.txtTotP4P.Name = "txtTotP4P";
            this.txtTotP4P.Size = new System.Drawing.Size(100, 20);
            this.txtTotP4P.TabIndex = 36;
            // 
            // txtTotRebate
            // 
            this.txtTotRebate.Location = new System.Drawing.Point(952, 351);
            this.txtTotRebate.Name = "txtTotRebate";
            this.txtTotRebate.Size = new System.Drawing.Size(100, 20);
            this.txtTotRebate.TabIndex = 35;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(1054, 324);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(27, 13);
            this.Label11.TabIndex = 27;
            this.Label11.Text = "P4P";
            // 
            // txtTotIncl
            // 
            this.txtTotIncl.Location = new System.Drawing.Point(846, 351);
            this.txtTotIncl.Name = "txtTotIncl";
            this.txtTotIncl.Size = new System.Drawing.Size(100, 20);
            this.txtTotIncl.TabIndex = 34;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(948, 324);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(42, 13);
            this.Label10.TabIndex = 29;
            this.Label10.Text = "Rebate";
            // 
            // txtTotVAT
            // 
            this.txtTotVAT.Location = new System.Drawing.Point(740, 351);
            this.txtTotVAT.Name = "txtTotVAT";
            this.txtTotVAT.Size = new System.Drawing.Size(100, 20);
            this.txtTotVAT.TabIndex = 37;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(842, 324);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(24, 13);
            this.Label9.TabIndex = 31;
            this.Label9.Text = "Incl";
            // 
            // txtTotExcl
            // 
            this.txtTotExcl.Location = new System.Drawing.Point(634, 351);
            this.txtTotExcl.Name = "txtTotExcl";
            this.txtTotExcl.Size = new System.Drawing.Size(100, 20);
            this.txtTotExcl.TabIndex = 33;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(736, 324);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(28, 13);
            this.Label8.TabIndex = 32;
            this.Label8.Text = "VAT";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(630, 280);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(36, 13);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "Totals";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(630, 324);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(27, 13);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Excl";
            // 
            // P4P
            // 
            this.P4P.HeaderText = "P4P Value";
            this.P4P.Name = "P4P";
            this.P4P.ReadOnly = true;
            this.P4P.Width = 82;
            // 
            // Apply
            // 
            this.Apply.HeaderText = "Apply Rebate";
            this.Apply.Name = "Apply";
            this.Apply.ReadOnly = true;
            this.Apply.Width = 96;
            // 
            // RebateValue
            // 
            this.RebateValue.HeaderText = "Rebate Value";
            this.RebateValue.Name = "RebateValue";
            this.RebateValue.ReadOnly = true;
            this.RebateValue.Width = 97;
            // 
            // RebateRate
            // 
            this.RebateRate.HeaderText = "Rebate Rate";
            this.RebateRate.Name = "RebateRate";
            this.RebateRate.ReadOnly = true;
            this.RebateRate.Width = 93;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 48;
            // 
            // Incl
            // 
            this.Incl.HeaderText = "Incl Amt";
            this.Incl.Name = "Incl";
            this.Incl.ReadOnly = true;
            this.Incl.Width = 70;
            // 
            // VAT
            // 
            this.VAT.HeaderText = "VAT Amt.";
            this.VAT.Name = "VAT";
            this.VAT.ReadOnly = true;
            this.VAT.Width = 77;
            // 
            // Excl
            // 
            this.Excl.HeaderText = "Excl Amt.";
            this.Excl.Name = "Excl";
            this.Excl.ReadOnly = true;
            this.Excl.Width = 76;
            // 
            // RebatePercentPerCase
            // 
            this.RebatePercentPerCase.HeaderText = "Invoice";
            this.RebatePercentPerCase.Name = "RebatePercentPerCase";
            this.RebatePercentPerCase.ReadOnly = true;
            this.RebatePercentPerCase.Width = 67;
            // 
            // RebatePerCase
            // 
            this.RebatePerCase.HeaderText = "Date";
            this.RebatePerCase.Name = "RebatePerCase";
            this.RebatePerCase.ReadOnly = true;
            this.RebatePerCase.Width = 55;
            // 
            // CustCode
            // 
            this.CustCode.HeaderText = "Customer";
            this.CustCode.Name = "CustCode";
            this.CustCode.ReadOnly = true;
            this.CustCode.Width = 76;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MMM-yy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(808, 39);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(168, 20);
            this.dtStart.TabIndex = 40;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dgSCRRebate
            // 
            this.dgSCRRebate.AllowUserToAddRows = false;
            this.dgSCRRebate.AllowUserToDeleteRows = false;
            this.dgSCRRebate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgSCRRebate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgSCRRebate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSCRRebate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustCode,
            this.RebatePerCase,
            this.RebatePercentPerCase,
            this.Excl,
            this.VAT,
            this.Incl,
            this.Qty,
            this.RebateRate,
            this.RebateValue,
            this.Apply,
            this.P4P});
            this.dgSCRRebate.Location = new System.Drawing.Point(12, 96);
            this.dgSCRRebate.Name = "dgSCRRebate";
            this.dgSCRRebate.ReadOnly = true;
            this.dgSCRRebate.RowTemplate.Height = 24;
            this.dgSCRRebate.Size = new System.Drawing.Size(1330, 166);
            this.dgSCRRebate.TabIndex = 26;
            this.dgSCRRebate.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSCRRebate_CellValueChanged);
            this.dgSCRRebate.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgSCRRebate_CurrentCellDirtyStateChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(993, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Date To";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(804, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Date From";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(12, 30);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(375, 26);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Self Collect Rebate: Apply Rebate";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(12, 75);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(1325, 2);
            this.Label3.TabIndex = 22;
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 3;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(1292, 11);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(56, 39);
            this.cmdExit.TabIndex = 21;
            this.cmdExit.Text = "X";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // frmSCRRebateApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 394);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtTotP4P);
            this.Controls.Add(this.txtTotRebate);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtTotIncl);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtTotVAT);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtTotExcl);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dgSCRRebate);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cmdExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSCRRebateApply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSCRRebateApply";
            this.Load += new System.EventHandler(this.frmSCRRebateApply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSCRRebate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtEnd;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtTotP4P;
        internal System.Windows.Forms.TextBox txtTotRebate;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtTotIncl;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtTotVAT;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtTotExcl;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn P4P;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Apply;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RebateValue;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RebateRate;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Incl;
        internal System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Excl;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RebatePercentPerCase;
        internal System.Windows.Forms.DataGridViewTextBoxColumn RebatePerCase;
        internal System.Windows.Forms.DataGridViewTextBoxColumn CustCode;
        internal System.Windows.Forms.DateTimePicker dtStart;
        internal System.Windows.Forms.DataGridView dgSCRRebate;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button cmdExit;
    }
}