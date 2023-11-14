using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF04
{
    internal class Class1
    {
        SqlConnection data = new SqlConnection("Data Source=DESKTOP-QNQBUT9\\LYKHACAM;Initial Catalog=QLWf04;Integrated Security=True");
        public DataTable ds_hoaqua(string a)
        {
            data.Open();
            SqlCommand cmd = new SqlCommand(a, data);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            data.Close();
            return dt;
        }
        public int thaydoi(string a)
        {
            data.Open();
            SqlCommand cmd = new SqlCommand(a, data);
            int row = cmd.ExecuteNonQuery();
            if(row > 0)
            {
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");

            }
            data.Close();
            return row;
        }
    }
}
