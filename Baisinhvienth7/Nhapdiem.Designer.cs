namespace Baisinhvienth7
{
    partial class Nhapdiem
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMaSo = new System.Windows.Forms.ComboBox();
            this.cbxHoTen = new System.Windows.Forms.ComboBox();
            this.cbxMaMH = new System.Windows.Forms.ComboBox();
            this.cbxTenMH = new System.Windows.Forms.ComboBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Môn ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Môn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Điểm ";
            // 
            // cbxMaSo
            // 
            this.cbxMaSo.FormattingEnabled = true;
            this.cbxMaSo.Location = new System.Drawing.Point(187, 76);
            this.cbxMaSo.Name = "cbxMaSo";
            this.cbxMaSo.Size = new System.Drawing.Size(147, 28);
            this.cbxMaSo.TabIndex = 2;
            // 
            // cbxHoTen
            // 
            this.cbxHoTen.FormattingEnabled = true;
            this.cbxHoTen.Location = new System.Drawing.Point(187, 129);
            this.cbxHoTen.Name = "cbxHoTen";
            this.cbxHoTen.Size = new System.Drawing.Size(211, 28);
            this.cbxHoTen.TabIndex = 2;
            // 
            // cbxMaMH
            // 
            this.cbxMaMH.FormattingEnabled = true;
            this.cbxMaMH.Location = new System.Drawing.Point(198, 185);
            this.cbxMaMH.Name = "cbxMaMH";
            this.cbxMaMH.Size = new System.Drawing.Size(147, 28);
            this.cbxMaMH.TabIndex = 2;
            // 
            // cbxTenMH
            // 
            this.cbxTenMH.FormattingEnabled = true;
            this.cbxTenMH.Location = new System.Drawing.Point(187, 235);
            this.cbxTenMH.Name = "cbxTenMH";
            this.cbxTenMH.Size = new System.Drawing.Size(211, 28);
            this.cbxTenMH.TabIndex = 2;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(187, 282);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(147, 26);
            this.txtDiem.TabIndex = 3;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(402, 356);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(95, 40);
            this.btnNhap.TabIndex = 4;
            this.btnNhap.Text = "Nhập ";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // Nhapdiem
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 444);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.cbxTenMH);
            this.Controls.Add(this.cbxMaMH);
            this.Controls.Add(this.cbxHoTen);
            this.Controls.Add(this.cbxMaSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nhapdiem";
            this.Text = "Nhập điểm ";
            this.Load += new System.EventHandler(this.Nhapdiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMaSo;
        private System.Windows.Forms.ComboBox cbxHoTen;
        private System.Windows.Forms.ComboBox cbxMaMH;
        private System.Windows.Forms.ComboBox cbxTenMH;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnNhap;
    }
}