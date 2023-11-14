using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TH07
{
    public partial class DanhMucKhoa : Form
    {
        public DanhMucKhoa()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void btnThem_Click(object sender, EventArgs e)
        {
            string crud = $"insert into Khoa values(N'{txtMaKhoa.Text}',N'{txtTenKhoa.Text}')";
            SqlCommand cmd = new SqlCommand(crud,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource=dtable;
            ConnectDatabase cont = new ConnectDatabase();
            string query = "select * from khoa";
            dataGridView1.DataSource = cont.getlist(query);
        }

        private void DanhMucKhoa_Load(object sender, EventArgs e)
        {
            ConnectDatabase cont = new ConnectDatabase();
            string query = "select * from khoa";
            dataGridView1.DataSource = cont.getlist(query);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhoa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenKhoa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=sinhvienVU2023NewNew;Integrated Security=True");
            string crud = $"Delete from khoa where makhoa = '{txtMaKhoa.Text}'";
            SqlCommand cmd = new SqlCommand(crud, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            ConnectDatabase cont = new ConnectDatabase();
            string query = "select * from khoa";
            dataGridView1.DataSource = cont.getlist(query);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
