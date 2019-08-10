namespace FLAME_TEST
{
    partial class CASE1
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbProductCate = new System.Windows.Forms.ComboBox();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.dpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnReloadReport = new System.Windows.Forms.Button();
            this.panelReport = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSalePerson = new System.Windows.Forms.ComboBox();
            this.panelFilter.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(820, 320);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilter.Controls.Add(this.cbSalePerson);
            this.panelFilter.Controls.Add(this.cbCustomer);
            this.panelFilter.Controls.Add(this.cbProductCate);
            this.panelFilter.Controls.Add(this.lbDateTo);
            this.panelFilter.Controls.Add(this.label3);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.lbDateFrom);
            this.panelFilter.Controls.Add(this.dpDateTo);
            this.panelFilter.Controls.Add(this.dpDateFrom);
            this.panelFilter.Controls.Add(this.btnReloadReport);
            this.panelFilter.Location = new System.Drawing.Point(12, 12);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(820, 100);
            this.panelFilter.TabIndex = 1;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(552, 21);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 3;
            // 
            // cbProductCate
            // 
            this.cbProductCate.FormattingEnabled = true;
            this.cbProductCate.Location = new System.Drawing.Point(420, 21);
            this.cbProductCate.Name = "cbProductCate";
            this.cbProductCate.Size = new System.Drawing.Size(121, 21);
            this.cbProductCate.TabIndex = 3;
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Location = new System.Drawing.Point(206, 5);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(53, 13);
            this.lbDateTo.TabIndex = 2;
            this.lbDateTo.Text = "DateFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Category";
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Location = new System.Drawing.Point(4, 4);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(53, 13);
            this.lbDateFrom.TabIndex = 2;
            this.lbDateFrom.Text = "DateFrom";
            // 
            // dpDateTo
            // 
            this.dpDateTo.Location = new System.Drawing.Point(209, 21);
            this.dpDateTo.Name = "dpDateTo";
            this.dpDateTo.Size = new System.Drawing.Size(200, 20);
            this.dpDateTo.TabIndex = 1;
            // 
            // dpDateFrom
            // 
            this.dpDateFrom.Location = new System.Drawing.Point(3, 21);
            this.dpDateFrom.Name = "dpDateFrom";
            this.dpDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dpDateFrom.TabIndex = 1;
            // 
            // btnReloadReport
            // 
            this.btnReloadReport.Location = new System.Drawing.Point(132, 58);
            this.btnReloadReport.Name = "btnReloadReport";
            this.btnReloadReport.Size = new System.Drawing.Size(114, 23);
            this.btnReloadReport.TabIndex = 0;
            this.btnReloadReport.Text = "ReloadReport";
            this.btnReloadReport.UseVisualStyleBackColor = true;
            this.btnReloadReport.Click += new System.EventHandler(this.BtnReloadReport_Click);
            // 
            // panelReport
            // 
            this.panelReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReport.Controls.Add(this.crystalReportViewer1);
            this.panelReport.Location = new System.Drawing.Point(12, 118);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(820, 320);
            this.panelReport.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SalePerson";
            // 
            // cbSalePerson
            // 
            this.cbSalePerson.FormattingEnabled = true;
            this.cbSalePerson.Location = new System.Drawing.Point(5, 60);
            this.cbSalePerson.Name = "cbSalePerson";
            this.cbSalePerson.Size = new System.Drawing.Size(121, 21);
            this.cbSalePerson.TabIndex = 3;
            // 
            // CASE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelFilter);
            this.Name = "CASE1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CASE1_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbProductCate;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.DateTimePicker dpDateTo;
        private System.Windows.Forms.DateTimePicker dpDateFrom;
        private System.Windows.Forms.Button btnReloadReport;
        private System.Windows.Forms.ComboBox cbSalePerson;
        private System.Windows.Forms.Label label3;
    }
}

