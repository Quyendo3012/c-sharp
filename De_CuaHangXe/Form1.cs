using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_CuaHangXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //kết nối sql 
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=CuaHangXe;Integrated Security=True");

        public DataTable getlist(string query)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);  // Query , sqlconnect
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Truyen sqlCommand
            DataTable dtable = new DataTable(); // data table trả về 1 bảng 
            adapter.Fill(dtable);
            connection.Close();
            return dtable;
        }

        public void Command(string query)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }



        //ý 6 1 điểm
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng chương trình không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //ý 3 bắt lỗi ô nhập sdt chỉ đc nhập ký tự số 
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txtSdt.Text.Length != 0)
                {
                    int sdt = Convert.ToInt32(txtSdt.Text);
                }
            }
            catch
            {
                MessageBox.Show("Vui long nhap chu");
            }
        }

        private void btnTinh_KeyDown(object sender, KeyEventArgs e)
        {

        }

      

        public void Connect()
        {
            string query = "select * from TTHoaDon";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnTinh;

        }

        //ý 4 
        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {

                int tien = int.Parse(txtGiatien.Text);
                txtPhuthu.Text = ((tien * 5) / 100).ToString();
                txtThue.Text = ((tien * 8) / 100).ToString();
                txtThanhtien.Text = (tien + Convert.ToInt32(txtPhuthu.Text) + Convert.ToInt32(txtThue.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Vui long nhap GIÁ TIỀN ");
            }
        }
        //ý 5
        private void btnTiep_Click(object sender, EventArgs e)
        {
            int mau = 1;
            if (radDen.Checked == true)
            {
                mau = 0;
            }
            try
            {
                string query = "INSERT INTO TTHoaDon Hoten , Diachi, Sdt, Mauxe, Giatien, Thanhtien) VALUES(N'" + txtHoten.Text + "',N'" + txtDiachi.Text + "',N'" + txtSdt.Text + "'," + mau + "," + txtGiatien.Text + "," + txtThanhtien.Text + ")";
                Connect();
            }
            catch
            {
                MessageBox.Show("Điền hết thống tin đi ạ!!!");
            }
            txtHoten.Focus();
            txtHoten.Text = "";
            txtDiachi.Text = "";
            txtSdt.Text = "";
            txtGiatien.Text = "";
            txtPhuthu.Text = "";
            txtThue.Text = "";
            txtThanhtien.Text = "";
            radDen.Checked = false;
            radKhac.Checked = false;

        }

        // ý 7 
   
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            int xeden = 0;
            int xekhac = 0;

            connection.Open();
            string query = "SELECT Mauxe, SUM(Thanhtien) as 'Thanhtien' FROM TTHoaDon  GROUP BY Mauxe";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int mau = reader.GetInt32(reader.GetOrdinal("Mauxe"));
            if (mau == 1)
             {
                    xeden = int.Parse(reader["Thanhtien"].ToString());
             }
             else
             {
                    xekhac = int.Parse(reader["Thanhtien"].ToString());
             }
            }
            connection.Close();

            MessageBox.Show("Xe đen có " + xeden + "\nXe khác có " + xekhac);
           
       

        }

       
    }
}

