namespace BCM_Automation_SAGE.FORMS
{
    partial class frmDashboard
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
            this.btnSCRCustMap = new System.Windows.Forms.Button();
            this.btnP4PCustMapping = new System.Windows.Forms.Button();
            this.btnP4PCustKPI = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSCRRebateApply = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSCRCustMap
            // 
            this.btnSCRCustMap.Location = new System.Drawing.Point(37, 34);
            this.btnSCRCustMap.Name = "btnSCRCustMap";
            this.btnSCRCustMap.Size = new System.Drawing.Size(96, 79);
            this.btnSCRCustMap.TabIndex = 0;
            this.btnSCRCustMap.Text = "SCR Cust Map";
            this.btnSCRCustMap.UseVisualStyleBackColor = true;
            this.btnSCRCustMap.Click += new System.EventHandler(this.btnSCRCustMap_Click);
            // 
            // btnP4PCustMapping
            // 
            this.btnP4PCustMapping.Location = new System.Drawing.Point(403, 34);
            this.btnP4PCustMapping.Name = "btnP4PCustMapping";
            this.btnP4PCustMapping.Size = new System.Drawing.Size(96, 79);
            this.btnP4PCustMapping.TabIndex = 1;
            this.btnP4PCustMapping.Text = "P4P Cust Mapping";
            this.btnP4PCustMapping.UseVisualStyleBackColor = true;
            this.btnP4PCustMapping.Click += new System.EventHandler(this.btnP4PCustMapping_Click);
            // 
            // btnP4PCustKPI
            // 
            this.btnP4PCustKPI.Location = new System.Drawing.Point(221, 34);
            this.btnP4PCustKPI.Name = "btnP4PCustKPI";
            this.btnP4PCustKPI.Size = new System.Drawing.Size(96, 79);
            this.btnP4PCustKPI.TabIndex = 2;
            this.btnP4PCustKPI.Text = "P4P Cust KPI";
            this.btnP4PCustKPI.UseVisualStyleBackColor = true;
            this.btnP4PCustKPI.Click += new System.EventHandler(this.btnP4PCustKPI_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(732, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 39);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSCRRebateApply
            // 
            this.btnSCRRebateApply.Location = new System.Drawing.Point(558, 34);
            this.btnSCRRebateApply.Name = "btnSCRRebateApply";
            this.btnSCRRebateApply.Size = new System.Drawing.Size(96, 79);
            this.btnSCRRebateApply.TabIndex = 20;
            this.btnSCRRebateApply.Text = "SCR Rebate Apply";
            this.btnSCRRebateApply.UseVisualStyleBackColor = true;
            this.btnSCRRebateApply.Click += new System.EventHandler(this.btnSCRRebateApply_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 3;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::BCM_Automation_SAGE.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(732, 74);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(45, 48);
            this.btnSettings.TabIndex = 21;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 162);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSCRRebateApply);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnP4PCustKPI);
            this.Controls.Add(this.btnP4PCustMapping);
            this.Controls.Add(this.btnSCRCustMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSCRCustMap;
        private System.Windows.Forms.Button btnP4PCustMapping;
        private System.Windows.Forms.Button btnP4PCustKPI;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSCRRebateApply;
        internal System.Windows.Forms.Button btnSettings;
    }
}