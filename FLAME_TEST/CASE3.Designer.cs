namespace FLAME_TEST
{
    partial class CASE3
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
            this.btnCountSpecialChar = new System.Windows.Forms.Button();
            this.btnReplaceChar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCountSpecialChar
            // 
            this.btnCountSpecialChar.Location = new System.Drawing.Point(180, 12);
            this.btnCountSpecialChar.Name = "btnCountSpecialChar";
            this.btnCountSpecialChar.Size = new System.Drawing.Size(152, 23);
            this.btnCountSpecialChar.TabIndex = 0;
            this.btnCountSpecialChar.Text = "CountSpecialChar";
            this.btnCountSpecialChar.UseVisualStyleBackColor = true;
            this.btnCountSpecialChar.Click += new System.EventHandler(this.BtnCountSpecialChar_Click);
            // 
            // btnReplaceChar
            // 
            this.btnReplaceChar.Location = new System.Drawing.Point(12, 12);
            this.btnReplaceChar.Name = "btnReplaceChar";
            this.btnReplaceChar.Size = new System.Drawing.Size(162, 23);
            this.btnReplaceChar.TabIndex = 0;
            this.btnReplaceChar.Text = "ReplaceChar";
            this.btnReplaceChar.UseVisualStyleBackColor = true;
            this.btnReplaceChar.Click += new System.EventHandler(this.BtnReplaceChar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 83);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(320, 355);
            this.txtResult.TabIndex = 2;
            // 
            // CASE3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReplaceChar);
            this.Controls.Add(this.btnCountSpecialChar);
            this.Name = "CASE3";
            this.Text = "CASE3";
            this.Load += new System.EventHandler(this.CASE3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountSpecialChar;
        private System.Windows.Forms.Button btnReplaceChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
    }
}