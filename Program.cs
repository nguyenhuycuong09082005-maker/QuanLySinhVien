using OOP_SV;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;


        SinhVien[] dsSV = new SinhVien[2];


        Console.WriteLine("--- NHẬP THÔNG TIN 2 SINH VIÊN ---");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Nhập sinh viên thứ {i + 1}:");
            dsSV[i] = new SinhVien();
            dsSV[i].NhapSV();
        }


        Console.WriteLine("\n--- Hien thi thong tin sinh vien ---");
        for (int i = 0; i < 2; i++)
        {
            dsSV[i].DisplaySV();
        }

        Console.ReadLine();
    }
}
