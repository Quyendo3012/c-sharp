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
    public partial class FormXemDiem : Form
    {
        public FormXemDiem()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");

        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            //string query = "select * from sinhvien as sv inner join ketqua as kq on sv.maso=kq.maso";
            string query = "select * from sinhvien";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1XemDiem.DataSource = dtable;

            //query = "select maso from sinhvien as sv inner join ketqua as kq on sv.maso=kq.maso";

            //cmd = new SqlCommand(query, con);
            //adapter = new SqlDataAdapter(cmd);
            //dtable = new DataTable();
            //adapter.Fill(dtable);
            cbxMaSo.DataSource = dtable;
            cbxMaSo.DisplayMember="MaSo";

            //query = "select hoten from sinhvien as sv inner join ketqua as kq on sv.maso=kq.maso";
            //cmd = new SqlCommand(query, con);
            //adapter = new SqlDataAdapter(cmd);
            //dtable = new DataTable();
            //adapter.Fill(dtable);
            cbxTenSV.DataSource = dtable;
            cbxTenSV.DisplayMember = "hoten";
            //cbxTenSV.DataBindings.Add("Text", cbxMaSo.DataSource, "hoten");
            txtKhoa.DataBindings.Add("Text", cbxMaSo.DataSource, "makhoa");
        }

        private void cbxMaSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxMaSo.SelectedIndex > 0)
            {
                string query = $"select ketqua.mamh,mon.tenmh,diem,mon.sotiet from ketqua inner join mon on ketqua.mamh = mon.mamh where maso = {cbxMaSo.Text}";
                query = "select * from sinhvien";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                //txtKhoa.Text = dtable.Rows[0].ItemArray[0].ToString();
            }    
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string query = $"select ketqua.mamh,mon.tenmh,diem,mon.sotiet from ketqua inner join mon on ketqua.mamh = mon.mamh where maso = {cbxMaSo.Text}";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            dataGridView1XemDiem.DataSource = dtable;
        }

        private void dataGridView1XemDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
