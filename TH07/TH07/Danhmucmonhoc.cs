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
    public partial class Danhmucmonhoc : Form
    {
        public Danhmucmonhoc()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void btnThem_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=sinhvienVU2023NewNew;Integrated Security=True");
            string crud = $"insert into mon values(N'{txtMaMH.Text}',N'{txtTenMH.Text}',{txtSoTiet.Text})";
            SqlCommand cmd = new SqlCommand(crud, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1MonHoc.DataSource = dtable;
            ConnectDatabase cont = new ConnectDatabase();
            string query = "select * from mon";
            dataGridView1MonHoc.DataSource = cont.getlist(query);
        }

        private void Danhmucmonhoc_Load(object sender, EventArgs e)
        {
            ConnectDatabase cont = new ConnectDatabase();
            string query = "select * from mon";
            dataGridView1MonHoc.DataSource = cont.getlist(query);
        }

        private void dataGridView1MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dataGridView1MonHoc.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dataGridView1MonHoc.CurrentRow.Cells[1].Value.ToString();
            txtSoTiet.Text = dataGridView1MonHoc.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query=$"delete from mon where mamh = {txtMaMH.Text}";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1MonHoc.DataSource = dtable;
            query = "select * from mon";
            cmd = new SqlCommand(query, con);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1MonHoc.DataSource = dtable;
        }
    }
}
