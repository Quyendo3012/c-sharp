using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace De_QLCB
{
    public partial class Form1 : Form
    {
        Connect cont = new Connect();

        public void homeLoad()
        {

            string query = "Select Row_Number() over(order by Id asc) , MaCB as 'Mã CB', Hoten as 'Họ tên', Ngaysinh as 'Ngày sinh', Gioitinh as 'Giới tính', Email as 'Email', Phone as 'Phone' from QLCB";
            dataGridView1.DataSource = cont.getlist(query);
             dataGridView1.Columns[0].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            homeLoad();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=QlyCB;Integrated Security=True");
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

      /*  private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }*/

      /* private void Form1_Load(object sender, EventArgs e)
        {

        }*/

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtMaCB.Text = row.Cells[1].Value.ToString();
            txtHoten.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = Convert.ToString(row.Cells[3].Value.ToString());
            string s = row.Cells[4].Value.ToString();
            if (s == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtPhone.Text = row.Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String s = "Nữ";
            if (radNam.Checked == true)
            {
                s = "Nam";
            }
            try
            {
                string crud = "insert into QLCB values(N'" + txtMaCB.Text + "', N'" + txtHoten.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "', N'" + s + "', N'" + txtEmail.Text + "', '" + txtPhone.Text + "' )";
                cont.Command(crud);
                homeLoad();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Nhập trùng rồi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String s = "Nữ";
            if (radNam.Checked == true)
            {
                s = "Nam";
            }
            string crud = "update QLCB set MaCB=N'" + txtMaCB.Text + "', Hoten=N'" + txtHoten.Text + "', Ngaysinh='"+dateTimePicker1.Value.ToShortDateString()+"', Gioitinh=N'"+s+"', Email=N'"+txtEmail.Text+"',Phone='"+txtPhone.Text+"'  where MaCB = '" + txtMaCB.Text + "' ";
            cont.Command(crud);
            homeLoad();
            MessageBox.Show("Cập nhật thành công");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string crud = "Delete from QLCB where MaCB = N'" + txtMaCB.Text + "' ";
            cont.Command(crud);
            homeLoad();
            MessageBox.Show("Xóa thành công");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            connection.Open();
            Connect cont = new Connect();
            string textToSearch = txtTim.Text;
            string query = "Select Row_Number() over(order by Id asc) , MaCB as 'Mã CB', Hoten as 'Họ tên', Ngaysinh as 'Ngày sinh', Gioitinh as 'Giới tính', Email as 'Email', Phone as 'Phone' from QLCB where Hoten like N'%" + textToSearch + "%'";
            dataGridView1.DataSource = cont.getlist(query);
            connection.Close();
        }
    }
}


