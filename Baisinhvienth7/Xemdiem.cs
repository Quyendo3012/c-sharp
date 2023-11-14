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
    public partial class Xemdiem : Form
    {
        public Xemdiem()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void Xemdiem_Load(object sender, EventArgs e)
        {
            string query = "select * from SinhVien";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            //query = "select maso from sinhvien as sv inner join ketqua as kq on sv.maso=kq.maso";

            //cmd = new SqlCommand(query, con);
            //adapter = new SqlDataAdapter(cmd);
            //dtable = new DataTable();
            //adapter.Fill(dtable);
            cbxMaSo.DataSource = dtable;
            cbxMaSo.DisplayMember = "MaSo";

            //query = "select hoten from sinhvien as sv inner join ketqua as kq on sv.maso=kq.maso";
            //cmd = new SqlCommand(query, con);
            //adapter = new SqlDataAdapter(cmd);
            //dtable = new DataTable();
            //adapter.Fill(dtable);
            cbxTenSV.DataSource = dtable;
            cbxTenSV.DisplayMember = "HoTen";
            //cbxTenSV.DataBindings.Add("Text", cbxMaSo.DataSource, "hoten");
            txtKhoa.DataBindings.Add("Text", cbxMaSo.DataSource, "MaKhoa");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = $"select KetQua.MaMH,Mon.TenMH,Diem,Mon.SoTiet from KetQua inner join Mon on KetQua.MaMH = Mon.MaMH where MaSo = {cbxMaSo.Text}";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
        }

        private void cbxMaSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaSo.SelectedIndex > 0)
            {
                string query = $"select KetQua.MaMH,Mon.TenMH,Diem,Mon.SoTiet from KetQua inner join Mon on KetQua.MaMH = Mon.MaMH where MaSo = {cbxMaSo.Text}";
                query = "select * from SinhVien";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                //txtKhoa.Text = dtable.Rows[0].ItemArray[0].ToString();
            }
        }
    }
}
