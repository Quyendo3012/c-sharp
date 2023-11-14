using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de3
{
    public partial class Form2 : Form
    {
        Connect cont = new Connect();
        public void homeLoad()
        {
            string query = "Select Row_Number() over(order by MaSV asc) 'STT' , MaSV as 'Mã SV', Hoten as 'Họ tên', Ngaysinh as 'Ngày sinh', Noisinh as 'Nơi sinh' , Gioitinh as 'Giới tính' from SV ";
            dataGridView1.DataSource = cont.getlist(query);
            dataGridView1.Columns[0].Visible = false;
        }
        public Form2()
        {
            InitializeComponent();
            homeLoad();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
    
        private void Form2_Load(object sender, EventArgs e)
        {
            Combo1();
        }

        private void Combo1()
        {
             string query1 = "select distinct Noisinh from SV";
        SqlDataAdapter adapter = new SqlDataAdapter(query1, connection);
        connection.Open();
            DataSet dt = new DataSet();
        adapter.Fill(dt, "Noisinh");
            cbNoisinh.DisplayMember = "Noisinh";
            cbNoisinh.ValueMember = "Noisinh";
            cbNoisinh.DataSource = dt.Tables["Noisinh"];
            connection.Close();
            if (cbNoisinh.Items.Count > 1)
            {
                cbNoisinh.SelectedIndex = -1;
            }
}
        private void btnTim_Click(object sender, EventArgs e)
        {
           
        }
    }
}
