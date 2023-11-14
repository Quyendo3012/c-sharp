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

namespace Baisinhvienth7
{
    public partial class Xemsvtheokhoa : Form
    {
        public Xemsvtheokhoa()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");

        private void Xemsvtheokhoa_Load(object sender, EventArgs e)
        {
            string query = "select MaSo,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai from Khoa inner join SinhVien "
                + "on Khoa.MaKhoa=SinhVien.MaKhoa";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            query = "select * from Khoa";
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
           
            cbxMaKhoa.DataSource = dtable;
            cbxMaKhoa.DisplayMember = "MaKhoa";
            //dataGridView1XemSVTheoKhoa.Columns[0].Visible = false;
            cbxTenKhoa.DataBindings.Add("Text", cbxMaKhoa.DataSource, "TenKhoa");

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = $"select MaSo,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai from Khoa inner join SinhVien on Khoa.MaKhoa=SinhVien.MaKhoa" + $" where Khoa.Makhoa = {cbxMaKhoa.Text} ";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }
    }
}
