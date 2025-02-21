namespace NotTakip
{
    partial class FrmNotGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMidtermNotu = new System.Windows.Forms.TextBox();
            this.txtFinalNotu = new System.Windows.Forms.TextBox();
            this.txtGecmeNotu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Midterm Notu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(127, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final Notu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gecme Notu:";
            // 
            // txtMidtermNotu
            // 
            this.txtMidtermNotu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMidtermNotu.Location = new System.Drawing.Point(364, 69);
            this.txtMidtermNotu.Name = "txtMidtermNotu";
            this.txtMidtermNotu.Size = new System.Drawing.Size(259, 50);
            this.txtMidtermNotu.TabIndex = 3;
            // 
            // txtFinalNotu
            // 
            this.txtFinalNotu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFinalNotu.Location = new System.Drawing.Point(364, 177);
            this.txtFinalNotu.Name = "txtFinalNotu";
            this.txtFinalNotu.Size = new System.Drawing.Size(259, 50);
            this.txtFinalNotu.TabIndex = 4;
            // 
            // txtGecmeNotu
            // 
            this.txtGecmeNotu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGecmeNotu.Location = new System.Drawing.Point(364, 281);
            this.txtGecmeNotu.Name = "txtGecmeNotu";
            this.txtGecmeNotu.Size = new System.Drawing.Size(259, 50);
            this.txtGecmeNotu.TabIndex = 5;
            this.txtGecmeNotu.TextChanged += new System.EventHandler(this.txtGecmeNotu_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(388, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNotGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1012, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGecmeNotu);
            this.Controls.Add(this.txtFinalNotu);
            this.Controls.Add(this.txtMidtermNotu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNotGiris";
            this.Text = "FrmNotGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMidtermNotu;
        private System.Windows.Forms.TextBox txtFinalNotu;
        private System.Windows.Forms.TextBox txtGecmeNotu;
        private System.Windows.Forms.Button button1;
    }
}