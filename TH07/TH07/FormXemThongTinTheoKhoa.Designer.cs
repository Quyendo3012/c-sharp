
namespace TH07
{
    partial class FormXemThongTinTheoKhoa
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
            this.btnXem = new System.Windows.Forms.Button();
            this.dataGridView1XemSVTheoKhoa = new System.Windows.Forms.DataGridView();
            this.cbxTenKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1XemSVTheoKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // cbxMaKhoa
            // 
            this.cbxMaKhoa.FormattingEnabled = true;
            this.cbxMaKhoa.Location = new System.Drawing.Point(206, 65);
            this.cbxMaKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMaKhoa.Name = "cbxMaKhoa";
            this.cbxMaKhoa.Size = new System.Drawing.Size(180, 28);
            this.cbxMaKhoa.TabIndex = 2;
            this.cbxMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxMaKhoa_SelectedIndexChanged);
            this.cbxMaKhoa.SelectedValueChanged += new System.EventHandler(this.cbxMaKhoa_SelectedValueChanged);
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(516, 112);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(112, 35);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dataGridView1XemSVTheoKhoa
            // 
            this.dataGridView1XemSVTheoKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1XemSVTheoKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1XemSVTheoKhoa.Location = new System.Drawing.Point(90, 183);
            this.dataGridView1XemSVTheoKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1XemSVTheoKhoa.Name = "dataGridView1XemSVTheoKhoa";
            this.dataGridView1XemSVTheoKhoa.RowHeadersWidth = 62;
            this.dataGridView1XemSVTheoKhoa.Size = new System.Drawing.Size(860, 409);
            this.dataGridView1XemSVTheoKhoa.TabIndex = 4;
            this.dataGridView1XemSVTheoKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1XemSVTheoKhoa_CellContentClick);
            // 
            // cbxTenKhoa
            // 
            this.cbxTenKhoa.FormattingEnabled = true;
            this.cbxTenKhoa.Location = new System.Drawing.Point(206, 115);
            this.cbxTenKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTenKhoa.Name = "cbxTenKhoa";
            this.cbxTenKhoa.Size = new System.Drawing.Size(277, 28);
            this.cbxTenKhoa.TabIndex = 5;
            // 
            // FormXemThongTinTheoKhoa
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1062, 655);
            this.Controls.Add(this.cbxTenKhoa);
            this.Controls.Add(this.dataGridView1XemSVTheoKhoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbxMaKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormXemThongTinTheoKhoa";
            this.Text = "Xem sinh viên theo khoa";
            this.Load += new System.EventHandler(this.FormXemThongTinTheoKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1XemSVTheoKhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMaKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dataGridView1XemSVTheoKhoa;
        private System.Windows.Forms.ComboBox cbxTenKhoa;
    }
}