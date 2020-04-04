using System;

namespace tamgiac
{
    class Program
    {
        struct DIEM
        {
            public double x, y;
        }

        static void Main(string[] args)
        {
            Console.Title = "Bài tập 20 ";
            //Khai báo 3 điểm A, B, C
            DIEM A, B, C;
            //Khai báo các số thực chu vi, diện tích
            double Cv, S;
            //Nhập liệu cho 3 điểm
            Console.Write("Diem A\nx=");
            A.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            A.y = double.Parse(Console.ReadLine());
            Console.Write("Diem B\nx=");
            B.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            B.y = double.Parse(Console.ReadLine());
            Console.Write("Diem C\nx=");
            C.x = double.Parse(Console.ReadLine());
            Console.Write("y=");
            C.y = double.Parse(Console.ReadLine());
            //Xử lý tính Chu vi, diện tích
            //Tính độ dài các cạnh
            double AB = Math.Sqrt((B.x - A.x) * (B.x - A.x) + (B.y -
           A.y) * (B.y - A.y));
            double BC = Math.Sqrt((C.x - B.x) * (C.x - B.x) + (C.y -
           B.y) * (C.y - B.y));
            double CA = Math.Sqrt((A.x - C.x) * (A.x - C.x) + (A.y -
           C.y) * (A.y - C.y));
            //Tính chu vi
            Cv = AB + BC + CA;
            //Tính nửa chu vi
            double P = Cv / 2;
            //Tính diện tích
            S = Math.Sqrt(P * (P - AB) * (P - BC) * (P - CA));
            //Kết xuất chu vi, diện tích
            string chuoi = "Chu vi:" + Cv + "\nDien tich:" + S;
            Console.Write(chuoi);
            Console.ReadLine();

        }
    }
}
