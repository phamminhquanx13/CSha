using System;

namespace PTB1
{
    class Program
    {
        static void Main(string[] args)
    {
        //để sử dụng hàm, ta có thể gọi hàm bằng tên hàm
        GiaiPhuongTrinh();
    }

    public static void GiaiPhuongTrinh()
    {
        Console.WriteLine("Day la ham giai phuong trinh bac nhat A*x + b = 0");
        Console.WriteLine("Nhap vao he so A");
        //double.Parse là hàm ép kiểu từ kiểu chuỗi sang kiểu số thực
        double soA = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao he so B");
        //Ta cũng có thể dùng lớp Convert để ép kiểu
        double soB = Convert.ToDouble(Console.ReadLine());

        //Nếu a = 0 và b khác 0
        if (soA == 0 && soB != 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }
        //nếu số b bằng 0
        else if (soB == 0)
        {
            Console.WriteLine("Phuong trinh co vo so nghiem");
        }
        //nếu a và b khác 0
        else
        {
            double ketQua = -soB / soA;
            Console.WriteLine("x = " +  ketQua);
        }
        Console.ReadLine();
    }
    }
}
