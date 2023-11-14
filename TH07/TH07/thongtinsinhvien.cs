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
    public partial class thongtinsinhvien : Form
    {
        public thongtinsinhvien()
        {
            InitializeComponent();
        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thongtinsinhvien_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            string query = "select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            //dataGridView1.DataSource = dtable;
            BindingSource bind = new BindingSource();
            bind.DataSource = dtable;
            dataGridView1.DataSource = bind;
            bindingNavigator1.BindingSource = bind; 
            //dataGridView1.DataSource = bindingSource1;

            //bindingSource1.DataSource = dtable;
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection (@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            int gioitinh =0;
            if (checkBox1.Checked == true)
            {
                gioitinh = 1;
            }
            string crud = $"INSERT INTO SinhVien VALUES({txtmaso.Text}, N'{txtHoten.Text}', '{dateTimePicker1NgaySinh.Value.ToShortDateString()}', '{gioitinh}', N'{txtDiaChi.Text}', {txtDienThoai.Text}, N'{txtKhoa.Text}')";
            SqlCommand cmd = new SqlCommand(crud,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            string query = "select * from SinhVien";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaso.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1NgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            checkBox1.Checked = (bool)dataGridView1.CurrentRow.Cells[3].Value;
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKhoa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            string crud = "delete from SinhVien where MaSo = "+$"'{txtmaso.Text}'";
            SqlCommand cmd = new SqlCommand(crud, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            string query = "select * from dssv";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            con.Close();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            int gioitinh = 0;
            if (checkBox1.Checked == true)
            {
                gioitinh = 1;
            }
            string crud = "update SINHVIEN "
                +$"set MaSo={txtmaso.Text},hoten=N'{txtHoten.Text}',ngaysinh='{dateTimePicker1NgaySinh.Value.ToShortDateString()}',gioitinh='{gioitinh}',diachi=N'{txtDiaChi.Text}',dienthoai='{txtDienThoai.Text}',makhoa=N'{txtKhoa.Text}'"
                +" where maso = " + $"'{txtmaso.Text}'";

            SqlCommand cmd = new SqlCommand(crud, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            string query = "select * from sinhvien";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            con.Close();

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            txtmaso.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1NgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            checkBox1.Checked = (bool)dataGridView1.CurrentRow.Cells[3].Value;
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtKhoa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtmaso_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
