namespace FLAME_TEST
{
    partial class CASE2
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
            this.txtInputNum = new System.Windows.Forms.TextBox();
            this.btnConvertToText = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputNum
            // 
            this.txtInputNum.Location = new System.Drawing.Point(39, 41);
            this.txtInputNum.Name = "txtInputNum";
            this.txtInputNum.Size = new System.Drawing.Size(151, 20);
            this.txtInputNum.TabIndex = 0;
            // 
            // btnConvertToText
            // 
            this.btnConvertToText.Location = new System.Drawing.Point(196, 39);
            this.btnConvertToText.Name = "btnConvertToText";
            this.btnConvertToText.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToText.TabIndex = 1;
            this.btnConvertToText.Text = "Convert";
            this.btnConvertToText.UseVisualStyleBackColor = true;
            this.btnConvertToText.Click += new System.EventHandler(this.BtnConvertToText_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(277, 44);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(32, 13);
            this.lbResult.TabIndex = 2;
            this.lbResult.Text = "result";
            // 
            // CASE2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 110);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnConvertToText);
            this.Controls.Add(this.txtInputNum);
            this.Name = "CASE2";
            this.Text = "CASE2";
            this.Load += new System.EventHandler(this.CASE2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputNum;
        private System.Windows.Forms.Button btnConvertToText;
        private System.Windows.Forms.Label lbResult;
    }
}