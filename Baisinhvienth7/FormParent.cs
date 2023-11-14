using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baisinhvienth7
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
            foreach (var item in this.MdiChildren)  
            {
                if (item.Name == "FormAbout") //đóng mọi form con đang hiển thị trên form MDI cha với tên "FormAbout",
                                            
                {
                    item.Close();
                }
            }
            FormAbout f = new FormAbout();   //sau đó tạo và hiển thị một FormAbout mới như một form con của form MDI cha đó.
            f.MdiParent = this;
            f.Show();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButtonSinhVien_Click(object sender, EventArgs e)
        {

            bool check = false;        //  kiểm tra xem trong danh sách các child form của form hiện tại đã có form tên "thongtinsinhvien" chưa.
                                     
            foreach (var item in this.MdiChildren)   
            {
                //item.Close();
                if (item.Name == "Thongtinsinhvien")
                {
                    check = true;   //  Nếu true là mở rồi 
                }
            }
            if (check == false)   //  nếu false, tức là chưa có mở form "thongtinsinhvien",
            {
                Thongtinsinhvien ttsv = new Thongtinsinhvien();   // khởi tạo một đối tượng mới của lớp Thongtinsinhvien lưu trữ thông tin về sinh viên
                ttsv.MdiParent = this; //`this` (đại diện cho form hiện tại) làm "cha" (MdiParent) của một đối tượng ToolStripStatusLabel (ttsv). 
                ttsv.Show(); //hiển thị lên form hiện tại. 
            }
            check = false; //Cuối cùng biến check lại được đặt bằng false để chuẩn bị cho lần kiểm tra tiếp theo.
        }

        private void toolStripButtonKhoa_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "Danhmuckhoa1")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                Danhmuckhoa1 dmk = new Danhmuckhoa1();
                dmk.MdiParent = this;  
                dmk.Show();
            }
            check = false; 
                
        }

        private void toolStripButtonMonHoc_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "Danhmucmonhoc" )
                {
                    check = true;
                }    
            } 
            if (check == false)
            {
                Danhmucmonhoc dmmh = new Danhmucmonhoc();
                dmmh.MdiParent = this;
                dmmh.Show();
            }
            check = false;
        }

        private void toolStripButtonNhapDiem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "Nhapdiem")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                Nhapdiem nhapdiem = new Nhapdiem();
                nhapdiem.MdiParent = this;
                nhapdiem.Show();
            }
        }

        private void toolStripButtonXemDiem_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if(item.Name == "Xemdiem")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                Xemdiem xemdiem = new Xemdiem();
                xemdiem.MdiParent = this;
                xemdiem.Show();
            }
        }

        private void toolStripButtonThongKe_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "Xemsvtheokhoa")
                {
                    check = true;
                }
            }
            if (check == false)
            {
                Xemsvtheokhoa xemsvtheokhoa = new Xemsvtheokhoa();
                xemsvtheokhoa.MdiParent = this;
                xemsvtheokhoa.Show();
            }
        }

        private void FormParent_Load(object sender, EventArgs e)
        {

        }
    }
}
