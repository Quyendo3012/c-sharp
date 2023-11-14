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
    public partial class Xemdiem : Form
    {
        public Xemdiem()
        {
            InitializeComponent();
        }

        private void Xemdiem_Load(object sender, EventArgs e)
        {
            ConnectDatabase a = new ConnectDatabase();
            string query = "SELECT        SinhVien.HoTen, Mon.TenMH, KetQua.Diem "+
"FROM            KetQua INNER JOIN "+
                         "Mon ON KetQua.MaMH = Mon.MaMH INNER JOIN "+
                         "SinhVien ON KetQua.Maso = SinhVien.MaSo";


            DataSet ds = a.getlist(query, "KetQua");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
