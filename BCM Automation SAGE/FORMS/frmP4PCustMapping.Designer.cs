namespace BCM_Automation_SAGE.FORMS
{
    partial class frmP4PCustMapping
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
            this.Label8 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtQ4 = new System.Windows.Forms.TextBox();
            this.txtQ3 = new System.Windows.Forms.TextBox();
            this.txtQ2 = new System.Windows.Forms.TextBox();
            this.txtTotalP4P = new System.Windows.Forms.TextBox();
            this.txtQ1 = new System.Windows.Forms.TextBox();
            this.optQ4 = new System.Windows.Forms.RadioButton();
            this.optQ3 = new System.Windows.Forms.RadioButton();
            this.optQ2 = new System.Windows.Forms.RadioButton();
            this.optQ1 = new System.Windows.Forms.RadioButton();
            this.cboCust = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dgKPI = new System.Windows.Forms.DataGridView();
            this.cmdExit = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtQtyAboveTarget = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRebateApplicable = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalRebate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgKPI)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(701, 135);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(350, 2);
            this.Label8.TabIndex = 50;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(927, 515);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(102, 43);
            this.cmdCancel.TabIndex = 49;
            this.cmdCancel.Text = "CANCEL";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(1035, 515);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(102, 43);
            this.cmdSave.TabIndex = 48;
            this.cmdSave.Text = "SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(538, 525);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(92, 13);
            this.Label5.TabIndex = 47;
            this.Label5.Text = "P4P Total Applied";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(701, 105);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 46;
            this.Label7.Text = "Targets";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(402, 124);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(51, 13);
            this.Label4.TabIndex = 45;
            this.Label4.Text = "Customer";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(209, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "End Date";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 124);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Start Date";
            // 
            // txtQ4
            // 
            this.txtQ4.Enabled = false;
            this.txtQ4.Location = new System.Drawing.Point(945, 185);
            this.txtQ4.Name = "txtQ4";
            this.txtQ4.Size = new System.Drawing.Size(100, 20);
            this.txtQ4.TabIndex = 41;
            // 
            // txtQ3
            // 
            this.txtQ3.Enabled = false;
            this.txtQ3.Location = new System.Drawing.Point(945, 150);
            this.txtQ3.Name = "txtQ3";
            this.txtQ3.Size = new System.Drawing.Size(100, 20);
            this.txtQ3.TabIndex = 40;
            // 
            // txtQ2
            // 
            this.txtQ2.Enabled = false;
            this.txtQ2.Location = new System.Drawing.Point(767, 185);
            this.txtQ2.Name = "txtQ2";
            this.txtQ2.Size = new System.Drawing.Size(100, 20);
            this.txtQ2.TabIndex = 42;
            // 
            // txtTotalP4P
            // 
            this.txtTotalP4P.Enabled = false;
            this.txtTotalP4P.Location = new System.Drawing.Point(704, 522);
            this.txtTotalP4P.Name = "txtTotalP4P";
            this.txtTotalP4P.Size = new System.Drawing.Size(179, 20);
            this.txtTotalP4P.TabIndex = 39;
            this.txtTotalP4P.Text = "0";
            // 
            // txtQ1
            // 
            this.txtQ1.Enabled = false;
            this.txtQ1.Location = new System.Drawing.Point(767, 150);
            this.txtQ1.Name = "txtQ1";
            this.txtQ1.Size = new System.Drawing.Size(100, 20);
            this.txtQ1.TabIndex = 38;
            // 
            // optQ4
            // 
            this.optQ4.AutoSize = true;
            this.optQ4.Location = new System.Drawing.Point(883, 185);
            this.optQ4.Name = "optQ4";
            this.optQ4.Size = new System.Drawing.Size(39, 17);
            this.optQ4.TabIndex = 37;
            this.optQ4.TabStop = true;
            this.optQ4.Text = "Q4";
            this.optQ4.UseVisualStyleBackColor = true;
            this.optQ4.CheckedChanged += new System.EventHandler(this.optQ4_CheckedChanged);
            // 
            // optQ3
            // 
            this.optQ3.AutoSize = true;
            this.optQ3.Location = new System.Drawing.Point(883, 150);
            this.optQ3.Name = "optQ3";
            this.optQ3.Size = new System.Drawing.Size(39, 17);
            this.optQ3.TabIndex = 36;
            this.optQ3.TabStop = true;
            this.optQ3.Text = "Q3";
            this.optQ3.UseVisualStyleBackColor = true;
            this.optQ3.CheckedChanged += new System.EventHandler(this.optQ3_CheckedChanged);
            // 
            // optQ2
            // 
            this.optQ2.AutoSize = true;
            this.optQ2.Location = new System.Drawing.Point(705, 185);
            this.optQ2.Name = "optQ2";
            this.optQ2.Size = new System.Drawing.Size(39, 17);
            this.optQ2.TabIndex = 35;
            this.optQ2.TabStop = true;
            this.optQ2.Text = "Q2";
            this.optQ2.UseVisualStyleBackColor = true;
            this.optQ2.CheckedChanged += new System.EventHandler(this.optQ2_CheckedChanged);
            // 
            // optQ1
            // 
            this.optQ1.AutoSize = true;
            this.optQ1.Location = new System.Drawing.Point(705, 150);
            this.optQ1.Name = "optQ1";
            this.optQ1.Size = new System.Drawing.Size(39, 17);
            this.optQ1.TabIndex = 34;
            this.optQ1.TabStop = true;
            this.optQ1.Text = "Q1";
            this.optQ1.UseVisualStyleBackColor = true;
            this.optQ1.CheckedChanged += new System.EventHandler(this.optQ1_CheckedChanged);
            // 
            // cboCust
            // 
            this.cboCust.FormattingEnabled = true;
            this.cboCust.Location = new System.Drawing.Point(406, 156);
            this.cboCust.Name = "cboCust";
            this.cboCust.Size = new System.Drawing.Size(261, 21);
            this.cboCust.TabIndex = 33;
            this.cboCust.SelectionChangeCommitted += new System.EventHandler(this.cboCust_SelectionChangeCommitted);
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd-MMM-yy";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(26, 157);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(168, 20);
            this.dtStart.TabIndex = 31;
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd-MMM-yy";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(213, 157);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(168, 20);
            this.dtEnd.TabIndex = 32;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dgKPI
            // 
            this.dgKPI.AllowUserToAddRows = false;
            this.dgKPI.AllowUserToDeleteRows = false;
            this.dgKPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKPI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKPI.Location = new System.Drawing.Point(23, 242);
            this.dgKPI.Name = "dgKPI";
            this.dgKPI.ReadOnly = true;
            this.dgKPI.RowTemplate.Height = 24;
            this.dgKPI.Size = new System.Drawing.Size(1114, 258);
            this.dgKPI.TabIndex = 30;
            this.dgKPI.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKPI_CellValueChanged);
            this.dgKPI.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgKPI_CurrentCellDirtyStateChanged);
            this.dgKPI.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgKPI_EditingControlShowing);
            // 
            // cmdExit
            // 
            this.cmdExit.FlatAppearance.BorderSize = 3;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(1081, 30);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(56, 39);
            this.cmdExit.TabIndex = 29;
            this.cmdExit.Text = "X";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(23, 37);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(214, 26);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "P4P: Apply Rebate";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(23, 82);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(1114, 2);
            this.Label3.TabIndex = 27;
            // 
            // txtQtyAboveTarget
            // 
            this.txtQtyAboveTarget.Enabled = false;
            this.txtQtyAboveTarget.Location = new System.Drawing.Point(25, 208);
            this.txtQtyAboveTarget.Name = "txtQtyAboveTarget";
            this.txtQtyAboveTarget.Size = new System.Drawing.Size(169, 20);
            this.txtQtyAboveTarget.TabIndex = 51;
            this.txtQtyAboveTarget.TextChanged += new System.EventHandler(this.txtQtyAboveTarget_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Qty Above Target";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Rebate Applicable";
            // 
            // txtRebateApplicable
            // 
            this.txtRebateApplicable.Enabled = false;
            this.txtRebateApplicable.Location = new System.Drawing.Point(211, 208);
            this.txtRebateApplicable.Name = "txtRebateApplicable";
            this.txtRebateApplicable.Size = new System.Drawing.Size(169, 20);
            this.txtRebateApplicable.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Total Rebate";
            // 
            // txtTotalRebate
            // 
            this.txtTotalRebate.Enabled = false;
            this.txtTotalRebate.Location = new System.Drawing.Point(404, 208);
            this.txtTotalRebate.Name = "txtTotalRebate";
            this.txtTotalRebate.Size = new System.Drawing.Size(169, 20);
            this.txtTotalRebate.TabIndex = 55;
            // 
            // frmP4PCustMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 573);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotalRebate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRebateApplicable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtQtyAboveTarget);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtQ4);
            this.Controls.Add(this.txtQ3);
            this.Controls.Add(this.txtQ2);
            this.Controls.Add(this.txtTotalP4P);
            this.Controls.Add(this.txtQ1);
            this.Controls.Add(this.optQ4);
            this.Controls.Add(this.optQ3);
            this.Controls.Add(this.optQ2);
            this.Controls.Add(this.optQ1);
            this.Controls.Add(this.cboCust);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dgKPI);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmP4PCustMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmP4PCustMapping";
            this.Load += new System.EventHandler(this.frmP4PCustMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtQ4;
        internal System.Windows.Forms.TextBox txtQ3;
        internal System.Windows.Forms.TextBox txtQ2;
        internal System.Windows.Forms.TextBox txtTotalP4P;
        internal System.Windows.Forms.TextBox txtQ1;
        internal System.Windows.Forms.RadioButton optQ4;
        internal System.Windows.Forms.RadioButton optQ3;
        internal System.Windows.Forms.RadioButton optQ2;
        internal System.Windows.Forms.RadioButton optQ1;
        internal System.Windows.Forms.ComboBox cboCust;
        internal System.Windows.Forms.DateTimePicker dtStart;
        internal System.Windows.Forms.DateTimePicker dtEnd;
        internal System.Windows.Forms.DataGridView dgKPI;
        internal System.Windows.Forms.Button cmdExit;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtQtyAboveTarget;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtRebateApplicable;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtTotalRebate;
    }
}