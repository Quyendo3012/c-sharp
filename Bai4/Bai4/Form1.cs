using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Viet o day
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //string rd = "";
            //if (rdNam.Checked)
            //{
            //    rd = "Nam";
            //}
            //else
            //{
            //    rd = "Nữ";
            //}
            ////dataGridViewSV.Rows.Add("Vũ","20/10/2003",rd,cbxQueQuan.Text,cbxLop.Text);
            //dataGridViewSV.Rows.Add(txtHT.Text,dateTimePicker1.Value.ToShortDateString(),rd,cbxQueQuan.Text,cbxLop.Text);
            //txtHT.Text = "";
            //cbxNS.Text = "";
            //rdNam.Checked = false;
            //rdNu.Checked = false;
            //cbxQueQuan.Text = "";
            //cbxLop.Text = "";

        }

        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtHT.Text = dataGridViewSV.CurrentRow.Cells[0].Value.ToString();
            //dateTimePicker1.Text= dataGridViewSV.CurrentRow.Cells[1].Value.ToString();
            //if (dataGridViewSV.CurrentRow.Cells[2].Value.ToString() == "Nam")
            //{
            //    rdNam.Checked = true;
            //}else if (dataGridViewSV.CurrentRow.Cells[2].Value.ToString() == "Nữ")
            //{
            //    rdNu.Checked = true;
            //}
            //else
            //{

            //}
            //cbxQueQuan.Text = dataGridViewSV.CurrentRow.Cells[3].Value.ToString();
            //cbxLop.Text = dataGridViewSV.CurrentRow.Cells[4].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Text);
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxNS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConectDatabase a = new ConectDatabase();
            string query = "SELECT dssv.msv AS [Mã sinh viên], dssv.hoten AS [Họ tên], dssv.ngaysinh AS [Ngày sinh], dssv.gioitinh AS [Giới tính], dssv.quequan AS [Quê quán], khoa.tenkhoa AS [Tên khoa], lop.tenlop AS [Tên lớp]"
                            + "FROM dssv INNER JOIN "
                            + "khoa ON dssv.makhoa = khoa.makhoa INNER JOIN "
                            + "lop ON dssv.malop = lop.malop";
            DataTable dtable =  a.getlist(query);
            dataGridViewSV.DataSource = dtable;

            query = "select * from khoa";
            cbxKhoa.DataSource = a.getlist(query);
            cbxKhoa.DisplayMember = "tenkhoa";
            cbxKhoa.ValueMember = "makhoa"; // lay gia tri luu tru

            cbxLop.DataSource = a.getlist("select * from lop");
            cbxLop.DisplayMember = "tenlop";
            cbxLop.ValueMember = "malop"; // lay gia tri luu tru



 
        }

        private void btnThemNew_Click(object sender, EventArgs e)
        {
            ConectDatabase a = new ConectDatabase();
            //string rd = "";
            //if (rdNam.Checked == true)
            //{
            //    rd = "Nam";
            //}
            //else
            //{
            //    rd = "Nữ";
            //}
            //string crud = "INSERT INTO dssv VALUES("+txtMSV.Text+","+ txtHT.Text+","+ dateTimePicker1.Text, rd, cbxQueQuan.Text);";
            //string crud = "INSERT INTO dssv (msv, hoten, ngaysinh, gioitinh, quequan) VALUES(N'"+txtMSV.Text+"', N'"+txtHT.Text+"', CONVERT(DATETIME, '"+dateTimePicker1.Text+"', 102), "+ rdNam.Checked + ", N'"+cbxQueQuan.Text+"')";
            
            
            //Chỗ này đang lỗi
            //string crud = $"INSERT INTO dssv VALUES({ txtMSV.Text} , {txtHT.Text},{dateTimePicker1.Text}, {rdNam.Checked}, {cbxQueQuan.Text})";
            //a.excute(crud);
        }
    }
}
