namespace BCM_Automation_SAGE.FORMS
{
    partial class frmP4PCustKPI
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
            this.Label13 = new System.Windows.Forms.Label();
            this.dgRebate = new System.Windows.Forms.DataGridView();
            this.cmdDelRebate = new System.Windows.Forms.Button();
            this.cmdSaveRebate = new System.Windows.Forms.Button();
            this.txtRebatePerCase = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.txtQtr4 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtQtr3 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgKPI = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCust = new System.Windows.Forms.ComboBox();
            this.txtQtr2 = new System.Windows.Forms.TextBox();
            this.txtQtr1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRebate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKPI)).BeginInit();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Black;
            this.Label13.Location = new System.Drawing.Point(677, 46);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(2, 223);
            this.Label13.TabIndex = 64;
            // 
            // dgRebate
            // 
            this.dgRebate.AllowUserToAddRows = false;
            this.dgRebate.AllowUserToDeleteRows = false;
            this.dgRebate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRebate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgRebate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRebate.Location = new System.Drawing.Point(692, 146);
            this.dgRebate.Margin = new System.Windows.Forms.Padding(2);
            this.dgRebate.Name = "dgRebate";
            this.dgRebate.ReadOnly = true;
            this.dgRebate.RowTemplate.Height = 24;
            this.dgRebate.Size = new System.Drawing.Size(309, 122);
            this.dgRebate.TabIndex = 63;
            this.dgRebate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRebate_CellDoubleClick);
            // 
            // cmdDelRebate
            // 
            this.cmdDelRebate.Location = new System.Drawing.Point(873, 110);
            this.cmdDelRebate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdDelRebate.Name = "cmdDelRebate";
            this.cmdDelRebate.Size = new System.Drawing.Size(68, 32);
            this.cmdDelRebate.TabIndex = 62;
            this.cmdDelRebate.Text = "DELETE";
            this.cmdDelRebate.UseVisualStyleBackColor = true;
            this.cmdDelRebate.Click += new System.EventHandler(this.cmdDelRebate_Click);
            // 
            // cmdSaveRebate
            // 
            this.cmdSaveRebate.Location = new System.Drawing.Point(801, 110);
            this.cmdSaveRebate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSaveRebate.Name = "cmdSaveRebate";
            this.cmdSaveRebate.Size = new System.Drawing.Size(68, 32);
            this.cmdSaveRebate.TabIndex = 61;
            this.cmdSaveRebate.Text = "SAVE";
            this.cmdSaveRebate.UseVisualStyleBackColor = true;
            this.cmdSaveRebate.Click += new System.EventHandler(this.cmdSaveRebate_Click);
            // 
            // txtRebatePerCase
            // 
            this.txtRebatePerCase.Location = new System.Drawing.Point(869, 87);
            this.txtRebatePerCase.Margin = new System.Windows.Forms.Padding(2);
            this.txtRebatePerCase.Name = "txtRebatePerCase";
            this.txtRebatePerCase.Size = new System.Drawing.Size(72, 20);
            this.txtRebatePerCase.TabIndex = 60;
            this.txtRebatePerCase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRebatePerCase_KeyPress);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(867, 68);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(77, 13);
            this.Label12.TabIndex = 59;
            this.Label12.Text = "Rebate / Case";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(795, 87);
            this.txtTo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(72, 20);
            this.txtTo.TabIndex = 58;
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTo_KeyPress);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(791, 68);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(20, 13);
            this.Label10.TabIndex = 57;
            this.Label10.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(719, 87);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(72, 20);
            this.txtFrom.TabIndex = 56;
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrom_KeyPress);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(717, 68);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(30, 13);
            this.Label11.TabIndex = 55;
            this.Label11.Text = "From";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(227, 76);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(29, 13);
            this.Label9.TabIndex = 54;
            this.Label9.Text = "Year";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(260, 73);
            this.cboYear.Margin = new System.Windows.Forms.Padding(2);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(74, 21);
            this.cboYear.TabIndex = 53;
            // 
            // txtQtr4
            // 
            this.txtQtr4.Location = new System.Drawing.Point(378, 116);
            this.txtQtr4.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtr4.Name = "txtQtr4";
            this.txtQtr4.Size = new System.Drawing.Size(47, 20);
            this.txtQtr4.TabIndex = 52;
            this.txtQtr4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtr4_KeyPress);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(376, 98);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(27, 13);
            this.Label8.TabIndex = 51;
            this.Label8.Text = "Qtr4";
            // 
            // txtQtr3
            // 
            this.txtQtr3.Location = new System.Drawing.Point(328, 116);
            this.txtQtr3.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtr3.Name = "txtQtr3";
            this.txtQtr3.Size = new System.Drawing.Size(47, 20);
            this.txtQtr3.TabIndex = 50;
            this.txtQtr3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtr3_KeyPress);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(325, 98);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(27, 13);
            this.Label7.TabIndex = 49;
            this.Label7.Text = "Qtr3";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(88, 110);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 32);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(959, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 32);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgKPI
            // 
            this.dgKPI.AllowUserToAddRows = false;
            this.dgKPI.AllowUserToDeleteRows = false;
            this.dgKPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKPI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgKPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKPI.Location = new System.Drawing.Point(7, 146);
            this.dgKPI.Margin = new System.Windows.Forms.Padding(2);
            this.dgKPI.Name = "dgKPI";
            this.dgKPI.ReadOnly = true;
            this.dgKPI.RowTemplate.Height = 24;
            this.dgKPI.Size = new System.Drawing.Size(656, 122);
            this.dgKPI.TabIndex = 46;
            this.dgKPI.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKPI_CellDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(16, 110);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 32);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboCust
            // 
            this.cboCust.FormattingEnabled = true;
            this.cboCust.Location = new System.Drawing.Point(14, 68);
            this.cboCust.Margin = new System.Windows.Forms.Padding(2);
            this.cboCust.Name = "cboCust";
            this.cboCust.Size = new System.Drawing.Size(201, 21);
            this.cboCust.TabIndex = 44;
            this.cboCust.SelectionChangeCommitted += new System.EventHandler(this.cboCust_SelectionChangeCommitted);
            // 
            // txtQtr2
            // 
            this.txtQtr2.Location = new System.Drawing.Point(278, 116);
            this.txtQtr2.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtr2.Name = "txtQtr2";
            this.txtQtr2.Size = new System.Drawing.Size(47, 20);
            this.txtQtr2.TabIndex = 42;
            this.txtQtr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtr2_KeyPress);
            // 
            // txtQtr1
            // 
            this.txtQtr1.Location = new System.Drawing.Point(228, 116);
            this.txtQtr1.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtr1.Name = "txtQtr1";
            this.txtQtr1.Size = new System.Drawing.Size(47, 20);
            this.txtQtr1.TabIndex = 43;
            this.txtQtr1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtr1_KeyPress);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(11, 9);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(303, 26);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "P4P Rebate: Customer KPI";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 49);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Select Customer";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(227, 68);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(188, 2);
            this.Label3.TabIndex = 38;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(275, 98);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(27, 13);
            this.Label5.TabIndex = 39;
            this.Label5.Text = "Qtr2";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(227, 98);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(27, 13);
            this.Label4.TabIndex = 40;
            this.Label4.Text = "Qtr1";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(227, 49);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(108, 13);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "KPI Per Qtr (in cases)";
            // 
            // frmP4PCustKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 297);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.dgRebate);
            this.Controls.Add(this.cmdDelRebate);
            this.Controls.Add(this.cmdSaveRebate);
            this.Controls.Add(this.txtRebatePerCase);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.txtQtr4);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtQtr3);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgKPI);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboCust);
            this.Controls.Add(this.txtQtr2);
            this.Controls.Add(this.txtQtr1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmP4PCustKPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P4P Customer KPI";
            this.Load += new System.EventHandler(this.frmP4PCustKPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRebate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgKPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.DataGridView dgRebate;
        internal System.Windows.Forms.Button cmdDelRebate;
        internal System.Windows.Forms.Button cmdSaveRebate;
        internal System.Windows.Forms.TextBox txtRebatePerCase;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtTo;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtFrom;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cboYear;
        internal System.Windows.Forms.TextBox txtQtr4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtQtr3;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.DataGridView dgKPI;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.ComboBox cboCust;
        internal System.Windows.Forms.TextBox txtQtr2;
        internal System.Windows.Forms.TextBox txtQtr1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
    }
}