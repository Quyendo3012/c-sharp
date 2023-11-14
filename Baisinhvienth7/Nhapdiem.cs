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
    public partial class Nhapdiem : Form
    {
        public Nhapdiem()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void Nhapdiem_Load(object sender, EventArgs e)
        {
            string query = "Select * from SinhVien";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            cbxMaSo.DataSource = dtable;
            cbxMaSo.DisplayMember = "Maso";

            cbxHoTen.DataSource = dtable;
            cbxHoTen.DisplayMember = "HoTen";

            query = "select * from Mon";
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            cbxMaMH.DataSource = dtable;
            cbxMaMH.DisplayMember = "MaMH";

            cbxTenMH.DataSource = dtable;
            cbxTenMH.DisplayMember = "TenMH";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string crud = String.Format("Insert into KetQua values({0},'{1}',{2})", cbxMaSo.Text, cbxMaMH.Text, txtDiem.Text);
                SqlCommand cmd = new SqlCommand(crud, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                MessageBox.Show("Nhập điểm thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập điểm");
            }
        }
    }
}
