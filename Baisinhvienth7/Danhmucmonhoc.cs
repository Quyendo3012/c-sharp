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
    public partial class Danhmucmonhoc : Form
    {
        public Danhmucmonhoc()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        private void Danhmucmonhoc_Load(object sender, EventArgs e)
        {
            Connect cont = new Connect();
            string query = "select * from Mon";
            dataGridView1.DataSource = cont.getlist(query);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string crud = $"insert into Mon values(N'{txtMaMH.Text}',N'{txtTenMH.Text}',{txtSoTiet.Text})";
            SqlCommand cmd = new SqlCommand(crud, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            Connect cont = new Connect();
            string query = "select * from mon";
            dataGridView1.DataSource = cont.getlist(query);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string crud = $"Delete from Mon where MaMH= '{txtMaMH.Text}'";
            SqlCommand cmd = new SqlCommand(crud, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;

            Connect cont = new Connect();
            string query = "select * from Mon";
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1.DataSource = dtable;
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoTiet.Text  = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoTiet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
    }
}
