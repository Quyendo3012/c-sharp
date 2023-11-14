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

namespace DetThongKe_Mess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtDT.Text.Length != 0)
            //    {
            //        int sdt = Convert.ToInt32(txtDT.Text);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Vui Lòng nhập số!!!");
            //    txtDT.Text = "";
            //}
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHT.Focus();
            txtHT.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtGT.Text = "";
            txtPhuThu.Text = "";
            txtThue.Text = "";
            txtThanhTien.Text = "";
            rdDen.Checked = false;
            rdKhac.Checked = false;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tien=int.Parse(txtGT.Text);
            txtPhuThu.Text = ((tien * 5) / 100).ToString();
            txtThue.Text = ((tien * 8) / 100).ToString();
            txtThanhTien.Text = (tien + Convert.ToInt32(txtPhuThu.Text) + Convert.ToInt32(txtThue.Text)).ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=Cuahangxe;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string query="select * from tthoadon";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            string query = "select sum([Thành tiền]) from TTHoaDon group by [Màu xe] having [Màu xe]=0";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            string xeden = dtable.Rows[0][0].ToString();
            query = "select sum([Thành tiền]) from TTHoaDon";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            string xekhac = (Convert.ToInt32(dtable.Rows[0][0].ToString()) - Convert.ToInt32(xeden)).ToString();
            MessageBox.Show("Xe đen có " + xeden + "\nXe khác có " + xekhac);
        }

        private void btnTinh_Click_1(object sender, EventArgs e)
        {
            try
            {
                int tien = int.Parse(txtGT.Text);
                txtPhuThu.Text = ((tien * 5) / 100).ToString();
                txtThue.Text = ((tien * 8) / 100).ToString();
                txtThanhTien.Text = (tien + Convert.ToInt32(txtPhuThu.Text) + Convert.ToInt32(txtThue.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Nhập đi em!");
            }
        }

        private void btnKetThuc_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTiep_Click_1(object sender, EventArgs e)
        {
            int mau=1;
            if(rdDen.Checked==true){
                mau=0;
            }
            try
            {
                string query = "INSERT INTO TTHoaDon ([Họ tên khách hàng], [Địa chỉ], [Số điện thoại], [Màu xe], [Giá tiền], [Thành tiền]) VALUES(N'" + txtHT.Text + "',N'" + txtDC.Text + "',N'" + txtDT.Text + "'," + mau + "," + txtGT.Text + "," + txtThanhTien.Text + ")";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
            }
            catch
            {
                MessageBox.Show("Điền hết thống tin đi ạ!!!");
            }
            txtHT.Focus();
            txtHT.Text = "";
            txtDC.Text = "";
            txtDT.Text = "";
            txtGT.Text = "";
            txtPhuThu.Text = "";
            txtThue.Text = "";
            txtThanhTien.Text = "";
            rdDen.Checked = false;
            rdKhac.Checked = false;
        }

        private void txtDT_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtDT.Text.Length != 0)
                {
                    int sdt = Convert.ToInt32(txtDT.Text);
                }
            }
            catch
            {
                MessageBox.Show("Vui Lòng nhập số!!!");
                txtDT.Text = "";
            }
        }
    }
}
