using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace thuchanh3_6
{
    internal class Modify
    {

    SqlDataReader sqlDataReader;
    SqlCommand sqlCommand;
    public void Command(string query)
    {
        using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }    
    }

    public DataTable GetDataTable(string query)
    {
        using (SqlConnection sqlConnection = Connection.GetSqlConnection())
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }    
    }
}
}
