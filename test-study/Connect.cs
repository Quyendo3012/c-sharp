using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace test_study
{
    internal class Connect
    {
       
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=test-study;Integrated Security=True");
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

        public void Command (string query)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        
    }
        
}
