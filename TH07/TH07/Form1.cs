using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "FormWelcome")
                {
                    item.Close();
                }
            }
            FormWelcome f = new FormWelcome();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //FormWelcome f = new FormWelcome();
            //f.ShowDialog();
            //SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=sinhvienVU2023NewNew;Integrated Security=True");
            //string query = "select * from sinhvien";
            //SqlCommand cmd = new SqlCommand(query,con);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dtable = new DataTable();
            //adapter.Fill(dtable);
            //thongtinsinhvien formttsv = new thongtinsinhvien();
            //formttsv.ShowDialog();

        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //bool check = false;
            //foreach (var item in this.MdiChildren)
            //{
            //    //item.Close();
            //    if (item.Name == "FormWelcome")
            //    {
            //        check = true;
            //    }
            //}
            //if (check == false)
            //{
            FormWelcome f = new FormWelcome();
            f.MdiParent = this;
            f.Show();
 
            //}
            //if (this.MdiChildren.Length > 0)
            //{
            //    this.MdiChildren[0].Close();

            //}


        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                //item.Close();
                if (item.Name == "thongtinsinhvien")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                thongtinsinhvien ttsv = new thongtinsinhvien();
                ttsv.MdiParent = this;
                ttsv.Show();
            }
            check = false;
            //foreach (var item in this.MdiChildren)
            //{
            //    if(item.Name=="thongtinsinhvien")
            //    {
            //        item.Close();
            //    }
            //}
            //thongtinsinhvien formttsv = new thongtinsinhvien();
            //formttsv.MdiParent = this;
            //formttsv.Show();
        }

        private void toolStripLabel2Khoa_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "DanhMucKhoa")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                DanhMucKhoa formDMK = new DanhMucKhoa();
                formDMK.MdiParent = this;
                formDMK.Show();
            }
        }

        private void toolStripLabel3MonHoc_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "Danhmucmonhoc")
                {
                    check = true;
                }
            }
            if(check==false)
            {
                Danhmucmonhoc formMH = new Danhmucmonhoc();
                formMH.MdiParent = this;
                formMH.Show();
            }
        }

        private void toolStripLabel5NhapDiem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "NhapDiem")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                NhapDiem formNhapDiem = new NhapDiem();
                formNhapDiem.MdiParent = this;
                formNhapDiem.Show();
            }
        }

        private void toolStripLabel7Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Bảng thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripLabel6ThongKeKhoa_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "FormXemThongTinTheoKhoa")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                FormXemThongTinTheoKhoa formXemTTtheoKhoa = new FormXemThongTinTheoKhoa();
                formXemTTtheoKhoa.MdiParent = this;
                formXemTTtheoKhoa.Show();
            }
        }

        private void toolStripLabel1XemDiem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "FormXemDiem")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                FormXemDiem formXemDiem = new FormXemDiem();
                formXemDiem.MdiParent = this;
                formXemDiem.Show();
            }
        }
    }
}
