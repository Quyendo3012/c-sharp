using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2

{
    class Program
    {
        static void Main(string[] args)
        {
            string hoTen;
            double diemToan;
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap diem toan: ");
            diemToan = double.Parse(Console.ReadLine());
            Console.WriteLine("Diem toan cua {0} la {1}", hoTen, diemToan);
            Console.ReadLine();
        }
    }
}