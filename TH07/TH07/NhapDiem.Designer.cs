
namespace TH07
{
    partial class NhapDiem
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.cbxMaSo = new System.Windows.Forms.ComboBox();
            this.cbxMMH = new System.Windows.Forms.ComboBox();
            this.cbxHT = new System.Windows.Forms.ComboBox();
            this.cbxTMH = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma So:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ho Ten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma Mon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ten Mon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Diem:";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(126, 168);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(80, 20);
            this.txtDiem.TabIndex = 6;
            // 
            // cbxMaSo
            // 
            this.cbxMaSo.FormattingEnabled = true;
            this.cbxMaSo.Location = new System.Drawing.Point(126, 52);
            this.cbxMaSo.Name = "cbxMaSo";
            this.cbxMaSo.Size = new System.Drawing.Size(105, 21);
            this.cbxMaSo.TabIndex = 7;
            // 
            // cbxMMH
            // 
            this.cbxMMH.FormattingEnabled = true;
            this.cbxMMH.Location = new System.Drawing.Point(126, 108);
            this.cbxMMH.Name = "cbxMMH";
            this.cbxMMH.Size = new System.Drawing.Size(105, 21);
            this.cbxMMH.TabIndex = 8;
            // 
            // cbxHT
            // 
            this.cbxHT.FormattingEnabled = true;
            this.cbxHT.Location = new System.Drawing.Point(126, 84);
            this.cbxHT.Name = "cbxHT";
            this.cbxHT.Size = new System.Drawing.Size(193, 21);
            this.cbxHT.TabIndex = 9;
            // 
            // cbxTMH
            // 
            this.cbxTMH.FormattingEnabled = true;
            this.cbxTMH.Location = new System.Drawing.Point(126, 138);
            this.cbxTMH.Name = "cbxTMH";
            this.cbxTMH.Size = new System.Drawing.Size(193, 21);
            this.cbxTMH.TabIndex = 10;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(244, 228);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // NhapDiem
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(361, 301);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.cbxTMH);
            this.Controls.Add(this.cbxHT);
            this.Controls.Add(this.cbxMMH);
            this.Controls.Add(this.cbxMaSo);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NhapDiem";
            this.Text = "NhapDiem";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.ComboBox cbxMaSo;
        private System.Windows.Forms.ComboBox cbxMMH;
        private System.Windows.Forms.ComboBox cbxHT;
        private System.Windows.Forms.ComboBox cbxTMH;
        private System.Windows.Forms.Button btnNhap;
    }
}