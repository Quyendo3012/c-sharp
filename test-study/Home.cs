using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test_study
{
    public partial class Home : Form
    {
        Connect cont = new Connect();

        public void homeLoad()
        {
            string query = "Select Row_Number() over(order by Id asc) 'STT', Id as 'Id', Tuvung as 'Từ vựng', Loaitu as 'Loại từ' from Tudien";
            dataGridView1.DataSource = cont.getlist(query);
           /* dataGridView1.Columns[1].Visible = false;*/
        }
        public Home()
        {
            InitializeComponent();
            homeLoad();
        }

      
        // bươc 1 kết nối sql 
      
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=test-study;Integrated Security=True");
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            //string crud 
           // cont.Command(crud);
           
            //homeLoad();
            string crud = "insert into Tudien values(N'"+txtId.Text.Trim()+"', N'"+txtTuvung.Text.Trim()+"',N'"+txtLoaitu.Text.Trim() +"')";
            cont.Command(crud);
            homeLoad();
            MessageBox.Show("Thêm mới thành công");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string crud = "Delete from Tudien where Id = '"+txtId.Text+"' ";
                cont.Command(crud);
                homeLoad();
                MessageBox.Show("Xóa thành công");
            } 
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
        try
            {
                string crud = "update Tudien Tuvung=N'"+txtTuvung.Text.Trim() +"',Loaitu=N'"+txtLoaitu.Text.Trim()+"'  where Id = '"+txtId.Text.Trim() +"'  " ;
                // + $"NgaySinh='{dateTimePickerNgaySinh.Value.ToShortDateString()}'," 
                cont.Command(crud);
                homeLoad();
                MessageBox.Show("Cập nhật thành công");
            }
        catch
            {
                MessageBox.Show("Cập nhật không thành công");           
            } 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         txtId.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         txtTuvung.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
         txtLoaitu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            Connect cont = new Connect();
            string textToSearch = searchBox.Text;
            string query = "Select Row_Number() over(order by Id asc) 'STT', Tuvung as 'Từ vựng'," +
                " Loaitu as 'Loại từ' from Tudien where Tuvung like N'%" + textToSearch + 
                "%' or Loaitu like N'%" +textToSearch + "%'";
            dataGridView1.DataSource = cont.getlist(query);
            connection.Close();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}



