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
    public partial class FormXemThongTinTheoKhoa : Form
    {
        public FormXemThongTinTheoKhoa()
        {
            InitializeComponent();
        }

        private void cbxMaKhoa_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbxTenKhoa.DataBindings.Add("Text",cbxMaKhoa.Text,"tenkhoa");
        }

        private void cbxMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbxTenKhoa.DataBindings.Add("Text",cbxMaKhoa.Text,"tenkhoa");
        }

        SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void FormXemThongTinTheoKhoa_Load(object sender, EventArgs e)
        {
            string query="select MaSo,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai from khoa inner join sinhvien on khoa.makhoa=sinhvien.makhoa";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1XemSVTheoKhoa.DataSource = dtable;

            query = "select * from khoa";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            cbxMaKhoa.DataSource = dtable;
            cbxMaKhoa.DisplayMember = "makhoa";
            //dataGridView1XemSVTheoKhoa.Columns[0].Visible = false;
            cbxTenKhoa.DataBindings.Add("Text",cbxMaKhoa.DataSource,"tenkhoa");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = $"select MaSo,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai from khoa inner join sinhvien on khoa.makhoa=sinhvien.makhoa where khoa.makhoa = {cbxMaKhoa.Text} ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1XemSVTheoKhoa.DataSource = dtable;
        }

        private void dataGridView1XemSVTheoKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
