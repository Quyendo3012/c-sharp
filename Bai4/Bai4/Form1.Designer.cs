
namespace Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.cbxQueQuan = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxNS = new System.Windows.Forms.ComboBox();
            this.btnThemNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(321, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(321, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(321, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khoa";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(130, 33);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(100, 20);
            this.txtMSV.TabIndex = 7;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(130, 82);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(100, 20);
            this.txtHT.TabIndex = 8;
            // 
            // cbxQueQuan
            // 
            this.cbxQueQuan.FormattingEnabled = true;
            this.cbxQueQuan.Items.AddRange(new object[] {
            "Hà Nội",
            "Quảng Ninh",
            "Hải Dương",
            "Nam Định",
            "Thanh Hóa"});
            this.cbxQueQuan.Location = new System.Drawing.Point(382, 33);
            this.cbxQueQuan.Name = "cbxQueQuan";
            this.cbxQueQuan.Size = new System.Drawing.Size(121, 21);
            this.cbxQueQuan.TabIndex = 10;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Items.AddRange(new object[] {
            "63CNTT1",
            "63CNTT2",
            "63CNTT3",
            "63CNTT4",
            "63CNTTVA",
            "63CNTTNB"});
            this.cbxLop.Location = new System.Drawing.Point(382, 82);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(121, 21);
            this.cbxLop.TabIndex = 11;
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Items.AddRange(new object[] {
            "CNTT",
            "MT",
            "CK"});
            this.cbxKhoa.Location = new System.Drawing.Point(382, 131);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbxKhoa.TabIndex = 12;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(130, 185);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 13;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(191, 185);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 14;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.AllowUserToAddRows = false;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Location = new System.Drawing.Point(4, 236);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.Size = new System.Drawing.Size(514, 182);
            this.dataGridViewSV.TabIndex = 15;
            this.dataGridViewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(428, 182);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Hiển thị";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 23, 22, 53, 20, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbxNS
            // 
            this.cbxNS.FormattingEnabled = true;
            this.cbxNS.Location = new System.Drawing.Point(130, 131);
            this.cbxNS.Name = "cbxNS";
            this.cbxNS.Size = new System.Drawing.Size(121, 21);
            this.cbxNS.TabIndex = 9;
            this.cbxNS.SelectedIndexChanged += new System.EventHandler(this.cbxNS_SelectedIndexChanged);
            // 
            // btnThemNew
            // 
            this.btnThemNew.Location = new System.Drawing.Point(277, 185);
            this.btnThemNew.Name = "btnThemNew";
            this.btnThemNew.Size = new System.Drawing.Size(75, 23);
            this.btnThemNew.TabIndex = 18;
            this.btnThemNew.Text = "Thêm";
            this.btnThemNew.UseVisualStyleBackColor = true;
            this.btnThemNew.Click += new System.EventHandler(this.btnThemNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 418);
            this.Controls.Add(this.btnThemNew);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxQueQuan);
            this.Controls.Add(this.cbxNS);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.ComboBox cbxQueQuan;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxNS;
        private System.Windows.Forms.Button btnThemNew;
    }
}

