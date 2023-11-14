
namespace TH07
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelSinhVien = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2Khoa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3MonHoc = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5NhapDiem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1XemDiem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel6ThongKeKhoa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7Thoat = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(210)))), ((int)(((byte)(249)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "&Chức năng";
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "&Hỗ trợ";
            this.hỗTrợToolStripMenuItem.Click += new System.EventHandler(this.hỗTrợToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(221)))), ((int)(((byte)(250)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.toolStripLabelSinhVien,
            this.toolStripLabel2Khoa,
            this.toolStripLabel3MonHoc,
            this.toolStripLabel5NhapDiem,
            this.toolStripLabel1XemDiem,
            this.toolStripSeparator1,
            this.toolStripLabel6ThongKeKhoa,
            this.toolStripLabel7Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 46);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 43);
            // 
            // toolStripLabelSinhVien
            // 
            this.toolStripLabelSinhVien.Image = global::TH07.Properties.Resources.svimg;
            this.toolStripLabelSinhVien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabelSinhVien.Name = "toolStripLabelSinhVien";
            this.toolStripLabelSinhVien.Size = new System.Drawing.Size(94, 43);
            this.toolStripLabelSinhVien.Text = "Sinh viên";
            this.toolStripLabelSinhVien.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2Khoa
            // 
            this.toolStripLabel2Khoa.Image = global::TH07.Properties.Resources.khoaimg;
            this.toolStripLabel2Khoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel2Khoa.Name = "toolStripLabel2Khoa";
            this.toolStripLabel2Khoa.Size = new System.Drawing.Size(71, 43);
            this.toolStripLabel2Khoa.Text = "Khoa";
            this.toolStripLabel2Khoa.Click += new System.EventHandler(this.toolStripLabel2Khoa_Click);
            // 
            // toolStripLabel3MonHoc
            // 
            this.toolStripLabel3MonHoc.Image = global::TH07.Properties.Resources.mhImg;
            this.toolStripLabel3MonHoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel3MonHoc.Name = "toolStripLabel3MonHoc";
            this.toolStripLabel3MonHoc.Size = new System.Drawing.Size(98, 43);
            this.toolStripLabel3MonHoc.Text = "Môn học";
            this.toolStripLabel3MonHoc.Click += new System.EventHandler(this.toolStripLabel3MonHoc_Click);
            // 
            // toolStripLabel5NhapDiem
            // 
            this.toolStripLabel5NhapDiem.Image = global::TH07.Properties.Resources.nhapdiemimg;
            this.toolStripLabel5NhapDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel5NhapDiem.Name = "toolStripLabel5NhapDiem";
            this.toolStripLabel5NhapDiem.Size = new System.Drawing.Size(102, 43);
            this.toolStripLabel5NhapDiem.Text = "Nhập điểm";
            this.toolStripLabel5NhapDiem.Click += new System.EventHandler(this.toolStripLabel5NhapDiem_Click);
            // 
            // toolStripLabel1XemDiem
            // 
            this.toolStripLabel1XemDiem.Image = global::TH07.Properties.Resources.xemdiemimg;
            this.toolStripLabel1XemDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1XemDiem.Name = "toolStripLabel1XemDiem";
            this.toolStripLabel1XemDiem.Size = new System.Drawing.Size(105, 43);
            this.toolStripLabel1XemDiem.Text = "Xem điểm";
            this.toolStripLabel1XemDiem.Click += new System.EventHandler(this.toolStripLabel1XemDiem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripLabel6ThongKeKhoa
            // 
            this.toolStripLabel6ThongKeKhoa.Image = global::TH07.Properties.Resources.thongkeImg;
            this.toolStripLabel6ThongKeKhoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel6ThongKeKhoa.Name = "toolStripLabel6ThongKeKhoa";
            this.toolStripLabel6ThongKeKhoa.Size = new System.Drawing.Size(128, 43);
            this.toolStripLabel6ThongKeKhoa.Text = "Thống kê khoa";
            this.toolStripLabel6ThongKeKhoa.Click += new System.EventHandler(this.toolStripLabel6ThongKeKhoa_Click);
            // 
            // toolStripLabel7Thoat
            // 
            this.toolStripLabel7Thoat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7Thoat.Image = global::TH07.Properties.Resources.thoatimg;
            this.toolStripLabel7Thoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel7Thoat.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
            this.toolStripLabel7Thoat.Name = "toolStripLabel7Thoat";
            this.toolStripLabel7Thoat.Size = new System.Drawing.Size(68, 43);
            this.toolStripLabel7Thoat.Text = "Thoát";
            this.toolStripLabel7Thoat.Click += new System.EventHandler(this.toolStripLabel7Thoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Image = global::TH07.Properties.Resources.user;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel2.Text = "HaGiang";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(268, 17);
            this.toolStripStatusLabel3.Text = "                                                                                 " +
    "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSinhVien;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2Khoa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3MonHoc;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5NhapDiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6ThongKeKhoa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7Thoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1XemDiem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

