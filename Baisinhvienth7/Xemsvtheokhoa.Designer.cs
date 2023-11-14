namespace Baisinhvienth7
{
    partial class Xemsvtheokhoa
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
            this.cbxMaKhoa = new System.Windows.Forms.ComboBox();
            this.cbxTenKhoa = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khoa ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khoa ";
            // 
            // cbxMaKhoa
            // 
            this.cbxMaKhoa.FormattingEnabled = true;
            this.cbxMaKhoa.Location = new System.Drawing.Point(167, 56);
            this.cbxMaKhoa.Name = "cbxMaKhoa";
            this.cbxMaKhoa.Size = new System.Drawing.Size(168, 28);
            this.cbxMaKhoa.TabIndex = 2;
            // 
            // cbxTenKhoa
            // 
            this.cbxTenKhoa.FormattingEnabled = true;
            this.cbxTenKhoa.Location = new System.Drawing.Point(167, 112);
            this.cbxTenKhoa.Name = "cbxTenKhoa";
            this.cbxTenKhoa.Size = new System.Drawing.Size(168, 28);
            this.cbxTenKhoa.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(434, 108);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(87, 34);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(973, 370);
            this.dataGridView1.TabIndex = 4;
            // 
            // Xemsvtheokhoa
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbxTenKhoa);
            this.Controls.Add(this.cbxMaKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Xemsvtheokhoa";
            this.Text = "Xem thông tin sinh viên theo khoa ";
            this.Load += new System.EventHandler(this.Xemsvtheokhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMaKhoa;
        private System.Windows.Forms.ComboBox cbxTenKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}