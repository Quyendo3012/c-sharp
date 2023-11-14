using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string hienthi = "select row_number() over (order by id) as 'stt', tensp as 'Tên sản phẩm', dongia as 'Đơn giá', soluong as 'Số lượng', thanhtien as 'Thành tiền'  from hoaqua";

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 dl = new Class1();
            DataTable dt = dl.ds_hoaqua(hienthi);
            dataGridView1.DataSource = dt;
        }

        private void cbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLoai.SelectedIndex)
            {
                case 0:
                    {
                        txtGia.Text = "1500";
                        break;
                    }
                case 1:
                    {
                        txtGia.Text = "2500";
                        break;
                    }
                case 2:
                    {
                        txtGia.Text = "4000";
                        break;
                    }
                case 3:
                    {
                        txtGia.Text = "5000";
                        break;
                    }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string them = "insert into hoaqua values('" + cbLoai.Text + "', '" + txtGia.Text + "','" + nbSoluong.Value.ToString() + "', '" + (nbSoluong.Value * Convert.ToInt32(txtGia.Text)) + "')";
            Class1 dl = new Class1();
            int row = dl.thaydoi(them);
            int bigdata = dl.thaydoi("insert into dulieu values('"+DateTime.Today.ToString()+"','" + cbLoai.Text + "', '" + txtGia.Text + "','" + nbSoluong.Value.ToString() + "', '" + (nbSoluong.Value * Convert.ToInt32(txtGia.Text)) + "')");
            DataTable dt = dl.ds_hoaqua(hienthi);
            dataGridView1.DataSource = dt;
            DataTable tong = dl.ds_hoaqua("select sum(thanhtien) as 'Tong' from hoaqua");
            txtTong.Text = tong.Rows[0].ItemArray[0].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string reset = "delete from hoaqua";
            Class1 dl = new Class1();
            int row = dl.thaydoi(reset);
            DataTable dt = dl.ds_hoaqua(hienthi);
            dataGridView1.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string xoa = "delete from hoaqua where id = '" + dataGridView1.CurrentRow.Cells[0].Value + "'";
            Class1 dl = new Class1();
            int row = dl.thaydoi(xoa);
            DataTable dt = dl.ds_hoaqua(hienthi);
            dataGridView1.DataSource = dt;
            DataTable tong = dl.ds_hoaqua("select sum(thanhtien) as 'Tong' from hoaqua");
            txtTong.Text = tong.Rows[0].ItemArray[0].ToString();
        }

        private void txtDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int dua = Convert.ToInt32(txtDua.Text);
                int tong = Convert.ToInt32(txtTong.Text);
                txtTra.Text = (dua - tong).ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Nhập số đi bạn");
                txtDua.Clear();
            }
        }

        private void txtTra_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
