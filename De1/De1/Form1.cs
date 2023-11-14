using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button38_Click(object sender, EventArgs e)
        {

        }
        int tong = 0;
        int dem = 0;
        Dictionary<string, int> list = new Dictionary<string, int>();
        private void button59_Click(object sender, EventArgs e)
        {
            //float a = 7.5f;
            //int b = (int)a;
            Button btn = (Button)sender; // Button btn = sender as Button;
            if (btn.BackColor == Color.FromArgb(128, 255, 128))
            {
                dem -= 1;
                if (btn.Text.Contains("A") == true)
                {
                    tong -= 25000;
                    btn.BackColor = Color.FromArgb(192, 253, 254);

                }
                else if (btn.Text.Contains("B") == true)
                {
                    tong -= 30000;
                    btn.BackColor = Color.FromArgb(192, 255, 190);

                }
                else if (btn.Text.Contains("C") == true)
                {
                    tong -= 35000;
                    btn.BackColor = Color.FromArgb(255, 255, 193);

                }
                else if (btn.Text.Contains("D") == true)
                {
                    tong -= 40000;
                    btn.BackColor = Color.FromArgb(255, 190, 254);

                }
                else if (btn.Text.Contains("E") == true)
                {
                    tong -= 50000;
                    btn.BackColor = Color.FromArgb(249, 198, 202);

                }
                else if (btn.Text.Contains("F") == true)
                {
                    tong -= 45000;
                    btn.BackColor = Color.FromArgb(255, 224, 193);

                }
            }else
            {
                //dem += 1;
                btn.BackColor = Color.FromArgb(128, 255, 128);
                if (btn.Text.Contains("A") == true)
                {
                    tong += 25000;
                }
                else if (btn.Text.Contains("B") == true)
                {
                    tong += 30000;
                }
                else if (btn.Text.Contains("C") == true)
                {
                    tong += 35000;
                }
                else if (btn.Text.Contains("D") == true)
                {
                    tong += 40000;
                }
                else if (btn.Text.Contains("E") == true)
                {
                    tong += 50000;
                }
                else if (btn.Text.Contains("F") == true)
                {
                    tong += 45000;
                }
            }
            label4.Text = tong.ToString();
            
            
        }
        Dictionary<string, string[]> listRedChair = new Dictionary<string, string[]>();

        private void button37_Click(object sender, EventArgs e)
        {
            string[] cacghe = new string[37];
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không", "Bảng thông báo", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                foreach(Control Item in tableLayoutPanel1.Controls) //Button
                {
                    if (Item.BackColor == Color.FromArgb(128, 255, 128)||Item.BackColor==Color.Red)
                    {
                        Item.BackColor = Color.Red;
                        Item.Enabled = false;
                        dem += 1;
                        cacghe[dem] = Item.Text;
                    }
                }
                if (!listRedChair.ContainsKey(cbxChonPhim.Text))
                {
                    listRedChair.Add(cbxChonPhim.Text,cacghe);

                }
                else
                {
                    listRedChair[cbxChonPhim.Text] = cacghe;
                }
                if (!list.ContainsKey(cbxChonPhim.Text))
                {
                    list.Add(cbxChonPhim.Text, dem);
                }else
                {
                    list[cbxChonPhim.Text] += dem;
                    label4.Text = "0";
                }
                dem = 0;
                tong = 0;

            }
        }

        private void cbxChonPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = cbxChonPhim.Text;
            int soghedachon = 0;
            if (list.ContainsKey(cbxChonPhim.Text))
            {
                 soghedachon = list[cbxChonPhim.Text];
           
            }
            lbDem.Text ="Có "+ soghedachon.ToString()+ " ghế đã chọn và có " + (tableLayoutPanel1.Controls.Count- soghedachon) + " ghế chưa chọn";
            foreach(Control btn in this.tableLayoutPanel1.Controls)
            {
                if (listRedChair.ContainsKey(cbxChonPhim.Text) && listRedChair[cbxChonPhim.Text].Contains(btn.Text))  //kiem tra danh sach ghe cua phim do
                {

                    btn.BackColor = Color.Red;
                    btn.Enabled = false;
                }
                else if (btn.Text.Contains("A") == true)
                {
                    btn.BackColor = Color.FromArgb(192, 253, 254);
                    btn.Enabled = true;

                }
                else if (btn.Text.Contains("B") == true)
                {
                    btn.BackColor = Color.FromArgb(192, 255, 190);
                    btn.Enabled = true;
                }
                else if (btn.Text.Contains("C") == true)
                {
                    btn.BackColor = Color.FromArgb(255, 255, 193);
                    btn.Enabled = true;
                }
                else if (btn.Text.Contains("D") == true)
                {
                    btn.BackColor = Color.FromArgb(255, 190, 254);
                    btn.Enabled = true;
                }
                else if (btn.Text.Contains("E") == true)
                {
                    btn.BackColor = Color.FromArgb(249, 198, 202);
                    btn.Enabled = true;
                }
                else if (btn.Text.Contains("F") == true)
                {
                    btn.BackColor = Color.FromArgb(255, 224, 193);
                    btn.Enabled = true;
                }
            }
        }
    }
}
