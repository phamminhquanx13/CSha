using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Bài tập 1";
            //Khai báo chuỗi họ tên
            string Ho_ten;
            //Khai báo ngày sinh
            DateTime Ngay_sinh;
            //Khai báo số nguyên tuổi
            int Tuoi;
            //Nhập liệu cho họ tên
            Console.Write("Ho Ten:");
            Ho_ten = Console.ReadLine();
            //Nhập liệu cho Ngày sinh
            Console.Write("Ngay Sinh:");
            Ngay_sinh = DateTime.Parse(Console.ReadLine());
            //Xử lý tính tuổi nhân viên
            Tuoi = DateTime.Today.Year - Ngay_sinh.Year;
            //Kết xuất tuổi nhân viên
            string chuoi = "Tuoi la:" + Tuoi;
            Console.Write(chuoi);
            ////////////////

        }
    }
}
