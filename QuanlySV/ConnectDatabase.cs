using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanlySV
{
     class ConnectDatabase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        DataSet dt = new DataSet();

        public DataSet getlist(string query, string tenbang)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();
            adapter.Fill(dt,tenbang);

            connection.Close();
            return dt;
        }
        public void EXCUTE (string Tsx)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(Tsx,connection);
                int lsx = cmd.ExecuteNonQuery();
                if (lsx > 0)
                {
                    MessageBox.Show("Thành Công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi"+ex.Message);
            }
        }
    }
    

}
