using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TH07
{
    class ConnectDatabase
    {
        SqlConnection con = new SqlConnection(@"Data Source=QDO\SQLEXPRESS;Initial Catalog=th7-b1;Integrated Security=True");
        DataSet dtset = new DataSet();

        public DataTable getlist(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);  // Query , sqlconnect
            SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Truyen sqlCommand
            DataTable dtable = new DataTable();
            adapter.Fill(dtable);
            //con.Close();
            return dtable;
        }

        //public DataTable excute(string crud)
        //{
        //    DataTable dtable = new DataTable();
        //    try
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand(crud, con);  // Query , sqlconnect
        //        //cmd.CommandType = CommandType.        Procedure
        //        int lagichaduoc = cmd.ExecuteNonQuery();
        //        if (lagichaduoc > 0)
        //        {
        //            MessageBox.Show("Thành công");   //using trc
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            adapter.Fill(dtable);
        //            return dtable;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Thất bại");   //using trc
        //        }

        //        con.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Lỗi " + e.Message.ToString());
        //    }
        //    return dtable;
        //}
    }
}
