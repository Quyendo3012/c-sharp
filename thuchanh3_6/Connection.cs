using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace thuchanh3_6
{
    internal class Connection
    {
        private static string connectionString = @"Data Source=QDO\SQLEXPRESS;Integrated Security=True; Database = btc#3_6";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString); 
        }
    }
}
