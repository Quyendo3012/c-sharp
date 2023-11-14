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
    public partial class NhapDiem : Form
    {
        public NhapDiem()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void NhapDiem_Load(object sender, EventArgs e)
        {
            string query = "Select * from sinhvien";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            cbxMaSo.DataSource = dtable;
            cbxMaSo.DisplayMember = "Maso";

            cbxHT.DataSource = dtable;
            cbxHT.DisplayMember = "HoTen";

            query = "select * from mon";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            cbxMMH.DataSource = dtable;
            cbxMMH.DisplayMember = "MaMH";

            cbxTMH.DataSource = dtable;
            cbxTMH.DisplayMember = "TenMH";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try{
                string crud = String.Format("Insert into ketqua values({0},'{1}',{2})", cbxMaSo.Text, cbxMMH.Text, txtDiem.Text);
                SqlCommand cmd = new SqlCommand(crud, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                MessageBox.Show("Thành công rồi!!!");
            }
            catch
            {
                MessageBox.Show("Hơi non ");
            }
        }
    }
}
