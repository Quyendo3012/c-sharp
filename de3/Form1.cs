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

namespace de3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            homeLoad();
        }

       
        Connect cont = new Connect();
        public void homeLoad()
        {
            string query = "Select Row_Number() over(order by MaSV asc) 'STT' , MaSV as 'Mã SV', Hoten as 'Họ tên', Ngaysinh as 'Ngày sinh', Noisinh as 'Nơi sinh' , Gioitinh as 'Giới tính' from SV ";
            dataGridView1.DataSource = cont.getlist(query);
            dataGridView1.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from SV", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbNoisinh.DisplayMember = "Noisinh";
            cbNoisinh.ValueMember = "MaSV";
            cbNoisinh.DataSource = dt;
            connection.Close();
         
        }
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
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
                string crud = "insert into SV values(N'" + txtMaSV.Text + "', N'" + txtHoten.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "',N'" + cbNoisinh.Text + "' ,N'" + s + "' )";
                cont.Command(crud);
                homeLoad();
                MessageBox.Show("Thêm mới thành công");
            }
            catch
            {
                MessageBox.Show("Thêm mới không thành công rồi");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            String s = "Nữ";
            if (radNam.Checked == true)
            {
                s = "Nam";
            }
            string crud = "update SV set MaSV=N'" + txtMaSV.Text + "', Hoten=N'" + txtHoten.Text + "', Ngaysinh='" + dateTimePicker1.Value.ToShortDateString() + "',Noisinh = N'" + cbNoisinh.Text + "' ,Gioitinh=N'" + s + "' where MaSV = '" + txtMaSV.Text + "' ";
            cont.Command(crud);
            homeLoad();
            MessageBox.Show("Cập nhật thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string crud = "Delete from SV where MaSV = N'" + txtMaSV.Text + "' ";
            cont.Command(crud);
            homeLoad();
            MessageBox.Show("Xóa thành công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.CurrentRow;
            txtMaSV.Text = row.Cells[1].Value.ToString();
            txtHoten.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = Convert.ToString(row.Cells[3].Value.ToString());
            cbNoisinh.Text = row.Cells[4].Value.ToString();
            string s = row.Cells[5].Value.ToString();
            if (s == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void cbNoisinh_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
