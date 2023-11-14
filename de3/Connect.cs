using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de3
{

    internal class Connect
    {
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True");
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
    }
}
