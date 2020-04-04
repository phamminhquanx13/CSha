using System;

namespace daucuoi
{
    class Program
    {
        struct MAT_HANG
        {
            public string Ten_hang;
            public double So_luong;
            public double Don_gia;
        }

        static void Main(string[] args)
        {

            /* int n;
             int Dau, Cuoi;
             Console.Write("n=");
             n = int.Parse(Console.ReadLine());
             Dau = n / 100;
             Cuoi = n % 10;
             string chuoi = "Chu so dau=" + Dau + "\nChu so cuoi=" +
            Cuoi;
             Console.Write(chuoi);
             Console.ReadLine();
             */
            Console.Title = "Bài tập 6";
            //Khai báo 1 Mặt hàng
            MAT_HANG Mh;
            //Khai báo số thực tiền trả
            double Tien_tra;
            //Nhập liệu cho mặt hàng
            Console.Write("Ten Hang:");
            Mh.Ten_hang = Console.ReadLine();

            Console.Write("So Luong:");
            Mh.So_luong = double.Parse(Console.ReadLine());
            Console.Write("Don Gia:");
            Mh.Don_gia = double.Parse(Console.ReadLine());
            Tien_tra = Mh.So_luong * Mh.Don_gia;
            if (Mh.So_luong >= 50 && Mh.So_luong <= 100)
                Tien_tra = Mh.So_luong * Mh.Don_gia * 0.92;
            else if (Mh.So_luong > 100)
                Tien_tra = Mh.So_luong * Mh.Don_gia * 0.88;
            
            string chuoi = "Tien tra:" + Tien_tra;
            Console.Write(chuoi);
            Console.ReadLine();

        }
    }
}
