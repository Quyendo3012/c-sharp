using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySV
{
    public partial class Khoa : Form
    {
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            ConnectDatabase a = new ConnectDatabase();
            string query = "select * from Khoa";
            DataSet dataSet =  a.getlist(query,"Khoa");
            dgrKhoa.DataSource = dataSet.Tables[0];


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ConnectDatabase a = new ConnectDatabase();
            string tsx = $"insert into Khoa values(N'{txtMaK.Text}',N'{txtTenK.Text}')";
            a.EXCUTE(tsx);
        }

    }
}
