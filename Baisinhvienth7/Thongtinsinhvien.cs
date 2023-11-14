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

namespace Baisinhvienth7
{
    public partial class Thongtinsinhvien : Form
    {
        public Thongtinsinhvien()
        {
            InitializeComponent();
        }

        private void Thongtinsinhvien_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True"); //kết nối csdl
            string query = "select * from SinhVien"; //truy vấn lệnh 
            SqlCommand cmd = new SqlCommand(query, connection); // tạo ra một `SqlCommand` mới với câu lệnh SQL được chỉ định và thực thi câu lệnh trên csdl.
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // kết nối và truy vấn csdl để thực hiện crud 
            DataTable dtable = new DataTable();  // lấy dữ liệu từ csdl đổ vào bảng 
            adapter.Fill(dtable);

            BindingSource bind = new BindingSource();       //
            bind.DataSource = dtable;
            dataGridViewttsv.DataSource = bind;
            bindingNavigator1.BindingSource = bind;
            connection.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            int gioitinh = 0;
            if (checkBoxGioiTinh.Checked == true)
            {
                gioitinh = 1;
            }
            string crud = $"insert into SinhVien values( {txtMaSo.Text} , N' {txtHoTen.Text} ', ' {dateTimePickerNgaySinh.Value.ToShortDateString()} ', ' {gioitinh} ', N' {txtDiaChi.Text} ',  {txtDienThoai.Text} , N' {txtMaKhoa.Text}')";
            SqlCommand cmd = new SqlCommand(crud, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridViewttsv.DataSource = dtable;

            string query = "select * from SinhVien";
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridViewttsv.DataSource = dtable;
            connection.Close();

        }

        private void dataGridViewttsv_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            txtMaSo.Text = dataGridViewttsv.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridViewttsv.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerNgaySinh.Text = dataGridViewttsv.CurrentRow.Cells[2].Value.ToString();
            checkBoxGioiTinh.Checked = (bool)dataGridViewttsv.CurrentRow.Cells[3].Value;
            txtDiaChi.Text = dataGridViewttsv.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dataGridViewttsv.CurrentRow.Cells[5].Value.ToString();
            txtMaKhoa.Text = dataGridViewttsv.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            string crud = $"Delete from SinhVien where MaSo = '{txtMaSo.Text}'";
            SqlCommand cmd = new SqlCommand(crud, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridViewttsv.DataSource = dtable;


            connection.Open();
            string query = "select * from SinhVien";
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridViewttsv.DataSource = dtable;
            connection.Close();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
            int gioitinh = 0;
            if (checkBoxGioiTinh.Checked == true)
            {
                gioitinh = 1;
            }
            string crud = "update SinhVien "
                + $"set MaSo={txtMaSo.Text},"
                +  $"HoTen=N'{txtHoTen.Text}'," 
                + $"NgaySinh='{dateTimePickerNgaySinh.Value.ToShortDateString()}'," 
                + $"GioiTinh='{gioitinh}'," 
                +  $"DiaChi=N'{txtDiaChi.Text}'," 
                +$"DienThoai='{txtDienThoai.Text}'," 
                + $"MaKhoa=N'{txtMaKhoa.Text}'" + " where MaSo = " + $"'{txtMaSo.Text}'";
              
            SqlCommand cmd = new SqlCommand(crud, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridViewttsv.DataSource = dtable;
            string query = "select * from SinhVien";
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridViewttsv.DataSource = dtable;
            connection.Close();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            txtMaSo.Text = dataGridViewttsv.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridViewttsv.CurrentRow.Cells[1].Value.ToString();
            dateTimePickerNgaySinh.Text = dataGridViewttsv.CurrentRow.Cells[2].Value.ToString();

            checkBoxGioiTinh.Checked = (bool)dataGridViewttsv.CurrentRow.Cells[3].Value;
            txtDiaChi.Text = dataGridViewttsv.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dataGridViewttsv.CurrentRow.Cells[5].Value.ToString();
            txtMaKhoa.Text = dataGridViewttsv.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
