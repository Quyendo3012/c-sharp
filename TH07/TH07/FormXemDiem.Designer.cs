
namespace TH07
{
    partial class FormXemDiem
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
            this.cbxMaSo = new System.Windows.Forms.ComboBox();
            this.cbxTenSV = new System.Windows.Forms.ComboBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.dataGridView1XemDiem = new System.Windows.Forms.DataGridView();
            this.btnXem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1XemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma so";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // cbxMaSo
            // 
            this.cbxMaSo.FormattingEnabled = true;
            this.cbxMaSo.Location = new System.Drawing.Point(112, 46);
            this.cbxMaSo.Name = "cbxMaSo";
            this.cbxMaSo.Size = new System.Drawing.Size(121, 21);
            this.cbxMaSo.TabIndex = 3;
            this.cbxMaSo.SelectedIndexChanged += new System.EventHandler(this.cbxMaSo_SelectedIndexChanged);
            // 
            // cbxTenSV
            // 
            this.cbxTenSV.FormattingEnabled = true;
            this.cbxTenSV.Location = new System.Drawing.Point(112, 85);
            this.cbxTenSV.Name = "cbxTenSV";
            this.cbxTenSV.Size = new System.Drawing.Size(182, 21);
            this.cbxTenSV.TabIndex = 5;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(112, 124);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(116, 20);
            this.txtKhoa.TabIndex = 6;
            // 
            // dataGridView1XemDiem
            // 
            this.dataGridView1XemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1XemDiem.Location = new System.Drawing.Point(54, 166);
            this.dataGridView1XemDiem.Name = "dataGridView1XemDiem";
            this.dataGridView1XemDiem.Size = new System.Drawing.Size(408, 227);
            this.dataGridView1XemDiem.TabIndex = 7;
            this.dataGridView1XemDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1XemDiem_CellContentClick);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(387, 127);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // FormXemDiem
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(497, 451);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dataGridView1XemDiem);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.cbxTenSV);
            this.Controls.Add(this.cbxMaSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormXemDiem";
            this.Text = "FormXemDiem";
            this.Load += new System.EventHandler(this.FormXemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1XemDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMaSo;
        private System.Windows.Forms.ComboBox cbxTenSV;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.DataGridView dataGridView1XemDiem;
        private System.Windows.Forms.Button btnXem;
    }
}