namespace NumberToText
{
    partial class Form1
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblWordedNumber = new System.Windows.Forms.Label();
            this.lblFormatedNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(12, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(361, 26);
            this.txtNum.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 60);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(361, 38);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert Whole Number To Text";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblWordedNumber
            // 
            this.lblWordedNumber.AutoSize = true;
            this.lblWordedNumber.Location = new System.Drawing.Point(8, 139);
            this.lblWordedNumber.Name = "lblWordedNumber";
            this.lblWordedNumber.Size = new System.Drawing.Size(51, 20);
            this.lblWordedNumber.TabIndex = 2;
            this.lblWordedNumber.Text = "label1";
            // 
            // lblFormatedNumber
            // 
            this.lblFormatedNumber.AutoSize = true;
            this.lblFormatedNumber.Location = new System.Drawing.Point(8, 113);
            this.lblFormatedNumber.Name = "lblFormatedNumber";
            this.lblFormatedNumber.Size = new System.Drawing.Size(51, 20);
            this.lblFormatedNumber.TabIndex = 3;
            this.lblFormatedNumber.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Whole Number Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormatedNumber);
            this.Controls.Add(this.lblWordedNumber);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblWordedNumber;
        private System.Windows.Forms.Label lblFormatedNumber;
        private System.Windows.Forms.Label label1;
    }
}

