using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            SinhVien sv= new SinhVien();
            sv.MdiParent= this;
            sv.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Nhapdiem nhapdiem = new Nhapdiem();
            nhapdiem.MdiParent = this;
            nhapdiem.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Xemdiem xemdiem = new Xemdiem();
            xemdiem.MdiParent = this;
            xemdiem.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            TkKhoa tkKhoa = new TkKhoa();
            tkKhoa.MdiParent = this;
            tkKhoa.Show();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Khoa khoa = new Khoa();
            khoa.MdiParent = this;
            khoa.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc();
            monHoc.MdiParent = this;
            monHoc.Show();
        }
    }
}
