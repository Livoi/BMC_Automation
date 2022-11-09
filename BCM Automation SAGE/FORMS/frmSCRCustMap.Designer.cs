namespace BCM_Automation_SAGE.FORMS
{
    partial class frmSCRCustMap
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
            this.dgScrMapping = new System.Windows.Forms.DataGridView();
            this.btnSaveScrMapping = new System.Windows.Forms.Button();
            this.cboCust = new System.Windows.Forms.ComboBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.txtPerCase = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDeleteScrMapping = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgScrMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // dgScrMapping
            // 
            this.dgScrMapping.AllowUserToAddRows = false;
            this.dgScrMapping.AllowUserToDeleteRows = false;
            this.dgScrMapping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgScrMapping.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgScrMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScrMapping.Location = new System.Drawing.Point(16, 183);
            this.dgScrMapping.Name = "dgScrMapping";
            this.dgScrMapping.ReadOnly = true;
            this.dgScrMapping.RowTemplate.Height = 24;
            this.dgScrMapping.Size = new System.Drawing.Size(527, 150);
            this.dgScrMapping.TabIndex = 17;
            this.dgScrMapping.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgScrMapping_CellDoubleClick);
            // 
            // btnSaveScrMapping
            // 
            this.btnSaveScrMapping.Location = new System.Drawing.Point(18, 138);
            this.btnSaveScrMapping.Name = "btnSaveScrMapping";
            this.btnSaveScrMapping.Size = new System.Drawing.Size(90, 39);
            this.btnSaveScrMapping.TabIndex = 16;
            this.btnSaveScrMapping.Text = "SAVE";
            this.btnSaveScrMapping.UseVisualStyleBackColor = true;
            this.btnSaveScrMapping.Click += new System.EventHandler(this.btnSaveScrMapping_Click);
            // 
            // cboCust
            // 
            this.cboCust.FormattingEnabled = true;
            this.cboCust.Location = new System.Drawing.Point(16, 90);
            this.cboCust.Name = "cboCust";
            this.cboCust.Size = new System.Drawing.Size(267, 21);
            this.cboCust.TabIndex = 15;
            this.cboCust.SelectionChangeCommitted += new System.EventHandler(this.cboCust_SelectionChangeCommitted);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(443, 123);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(100, 20);
            this.txtPercentage.TabIndex = 13;
            this.txtPercentage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentage_KeyPress);
            // 
            // txtPerCase
            // 
            this.txtPerCase.Location = new System.Drawing.Point(304, 123);
            this.txtPerCase.Name = "txtPerCase";
            this.txtPerCase.Size = new System.Drawing.Size(100, 20);
            this.txtPerCase.TabIndex = 14;
            this.txtPerCase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPerCase_KeyPress);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Select Customer";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(300, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(250, 2);
            this.Label3.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(439, 100);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 13);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Percentage";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(300, 100);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Per Case";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(300, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Rebate";
            // 
            // btnDeleteScrMapping
            // 
            this.btnDeleteScrMapping.Location = new System.Drawing.Point(114, 138);
            this.btnDeleteScrMapping.Name = "btnDeleteScrMapping";
            this.btnDeleteScrMapping.Size = new System.Drawing.Size(90, 39);
            this.btnDeleteScrMapping.TabIndex = 19;
            this.btnDeleteScrMapping.Text = "DELETE";
            this.btnDeleteScrMapping.UseVisualStyleBackColor = true;
            this.btnDeleteScrMapping.Click += new System.EventHandler(this.btnDeleteScrMapping_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(494, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 39);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(12, 18);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(166, 26);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "SCR: Mapping";
            // 
            // frmSCRCustMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 347);
            this.Controls.Add(this.dgScrMapping);
            this.Controls.Add(this.btnSaveScrMapping);
            this.Controls.Add(this.cboCust);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtPerCase);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnDeleteScrMapping);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSCRCustMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self Collect Rebate Customer Mapping";
            this.Load += new System.EventHandler(this.frmSCRCustMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgScrMapping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgScrMapping;
        internal System.Windows.Forms.Button btnSaveScrMapping;
        internal System.Windows.Forms.ComboBox cboCust;
        internal System.Windows.Forms.TextBox txtPercentage;
        internal System.Windows.Forms.TextBox txtPerCase;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDeleteScrMapping;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label Label6;
    }
}