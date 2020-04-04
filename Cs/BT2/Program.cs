using System;

namespace BT2
{
    class Program
    {

        struct DIEM
        {
            public double x, y;
        }
        static void Main(string[] args)
        {
            //Tên bài tập
            Console.Title = "Bài tập 2";
            //Khai báo điểm
            DIEM M;
            //Khai báo các số thực 3 hệ số của đường thẳng a, b, c
            double a, b, c;
            //Khai báo khoảng cách h
            double h;
            //Nhập liệu cho các toạ độ của M
            Console.Write("Diem M\nx=");
            M.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            M.y = double.Parse(Console.ReadLine());
            //Nhập liệu cho các hệ số của đường thẳng
            Console.Write("Cac he so cua duong thang\na=");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            c = double.Parse(Console.ReadLine());
            //Xử lý tính khoảng cách h
            double e = Math.Abs(a * M.x + b * M.y + c);
            double f = Math.Sqrt(a * a + b * b);
            h = e / f;
            //Xuất khoảng cách h
            string chuoi = "Khoang cach la:" + Math.Round(h, 1);
            Console.Write(chuoi);
            Console.ReadLine();
        }
    }
}
