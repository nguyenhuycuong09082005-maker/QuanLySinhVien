using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SV
{
    internal class SinhVien
    {
        public string msv;
        public string hoTen;
        public int tuoi;
        public SinhVien() { }

        public SinhVien(string msv, string hoTen, int tuoi)
        {
            this.msv = msv;
            this.hoTen = hoTen;
            this.tuoi = tuoi;
        }
        public void NhapSV()
        {
            Console.Write("Nhập MSV: ");
            msv = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập Tuổi: ");
            tuoi = int.Parse(Console.ReadLine());
        }

        public void DisplaySV()
        {
            Console.WriteLine("MSV: {0} | Họ tên: {1} | Tuổi: {2}", msv, hoTen, tuoi);
        }
    }

}
