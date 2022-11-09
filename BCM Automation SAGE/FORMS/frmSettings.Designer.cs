namespace BCM_Automation_SAGE.FORMS
{
    partial class frmSettings
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboP4PTaxRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboP4PGLAccounts = new System.Windows.Forms.ComboBox();
            this.fbdFileWatcherFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSCRTaxRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSCRGLAccounts = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.cboSCRTaxRate);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.cboSCRGLAccounts);
            this.Panel1.Controls.Add(this.btnClose);
            this.Panel1.Controls.Add(this.btnSave);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.cboP4PTaxRate);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.cboP4PGLAccounts);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(671, 286);
            this.Panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(612, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 39);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "P4P Tax Rate:.";
            // 
            // cboP4PTaxRate
            // 
            this.cboP4PTaxRate.FormattingEnabled = true;
            this.cboP4PTaxRate.Location = new System.Drawing.Point(202, 84);
            this.cboP4PTaxRate.Name = "cboP4PTaxRate";
            this.cboP4PTaxRate.Size = new System.Drawing.Size(360, 28);
            this.cboP4PTaxRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "P4P GL Account:.";
            // 
            // cboP4PGLAccounts
            // 
            this.cboP4PGLAccounts.FormattingEnabled = true;
            this.cboP4PGLAccounts.Location = new System.Drawing.Point(202, 43);
            this.cboP4PGLAccounts.Name = "cboP4PGLAccounts";
            this.cboP4PGLAccounts.Size = new System.Drawing.Size(360, 28);
            this.cboP4PGLAccounts.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "SCR Tax Rate:.";
            // 
            // cboSCRTaxRate
            // 
            this.cboSCRTaxRate.FormattingEnabled = true;
            this.cboSCRTaxRate.Location = new System.Drawing.Point(202, 168);
            this.cboSCRTaxRate.Name = "cboSCRTaxRate";
            this.cboSCRTaxRate.Size = new System.Drawing.Size(360, 28);
            this.cboSCRTaxRate.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "SCR GL Account:.";
            // 
            // cboSCRGLAccounts
            // 
            this.cboSCRGLAccounts.FormattingEnabled = true;
            this.cboSCRGLAccounts.Location = new System.Drawing.Point(202, 127);
            this.cboSCRGLAccounts.Name = "cboSCRGLAccounts";
            this.cboSCRGLAccounts.Size = new System.Drawing.Size(360, 28);
            this.cboSCRGLAccounts.TabIndex = 21;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 286);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.FolderBrowserDialog fbdFileWatcherFolder;
        private System.Windows.Forms.ComboBox cboP4PGLAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboP4PTaxRate;
        private System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSCRTaxRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSCRGLAccounts;
    }
}