using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            ConnectDatabase a = new ConnectDatabase();
            string query = "select * from SinhVien";
            DataSet data = a.getlist(query, "SinhVien");
            dataGridView1.DataSource= data.Tables[0];
        }

        ConnectDatabase a =new ConnectDatabase();
        private void btnThem_Click(object sender, EventArgs e)
        {
            int ck = 0;
            if (checkBox1.Checked == true)
            {
                ck = 1;
            }
            else
            {
                ck = 0;
            }
            string tsx = $"insert into SinhVien values({txtMsv.Text},N'{txtHoten.Text}','{dateTimePicker1.Value.ToShortDateString()}',{ck},N'{txtDiaChi.Text}',{txtSDT.Text},N'{cbKhoa.Text}')";
            a.EXCUTE(tsx);
            //ConnectDatabase b = new ConnectDatabase();
            string query = "select * from SinhVien";
            DataSet data = a.getlist(query, "SinhVien");
            dataGridView1.DataSource = data.Tables[0];

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtMsv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cbKhoa.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            checkBox1.Checked = (bool)dataGridView1.CurrentRow.Cells[3].Value;

            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //ConnectDatabase a = new ConnectDatabase();
            //string query = "delete from SinhVien where MaSo = '"+txtMsv.Text+"'";
            //a.EXCUTE(query);
        }
    }
}
