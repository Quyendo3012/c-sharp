using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Baisinhvienth7
{
   
    internal class Connect
    {
      
        SqlConnection connection = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        

        DataSet dtset = new DataSet(); //dataset trả về nhiều bảng

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

    }
}
