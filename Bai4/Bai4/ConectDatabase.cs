using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Bai4
{
    class ConectDatabase
    {
        SqlConnection con = new SqlConnection(@"Data Source=MSI\MSSQLSERVER01;Initial Catalog=qlsv2023newnew;Integrated Security=True");
        public DataTable getlist(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);  // Query , sqlconnect
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Truyen sqlCommand
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            con.Close();
            return dtable;
        }

        public void excute(string crud)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(crud, con);  // Query , sqlconnect
            int lagichaduoc = cmd.ExecuteNonQuery();
            if (lagichaduoc > 0)
            {
                System.Windows.Forms.MessageBox.Show("Thành công");   //using trc
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Thất bại");   //using trc
            }
            con.Close();
        }
    }
}
