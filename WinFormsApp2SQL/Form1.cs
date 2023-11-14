using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp2SQL
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=QDO\\SQLEXPRESS;database=Test; Integrated Security = true";

            SqlConnection con = new SqlConnection(str);

            con.Open();

            string query2 = "insert into Name(name) values(@name)";

            SqlCommand cmd = new SqlCommand(query2, con);
            cmd.Parameters.Add("@name", SqlDbType.VarChar);
            cmd.Parameters["@name"].Value = textBox1.Text;
            cmd.ExecuteNonQuery();

            con.Close();


            textBox1.Text = "";

            MessageBox.Show($"Add {textBox1.Text} successfully");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}