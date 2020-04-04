using System.Linq;
using System;

namespace mangsonguyen
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
            /*int[] a;

            int Tong, So_max, Slsd;

            Console.Write("Nhap so luong cac so nguyen cua a:");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + (i + 1) + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }

           Tong = a.Sum();
            So_max = a.Max();
            Slsd = a.Count(x => x > 0);

            string chuoi = "Tong:" + Tong + "\nSo lon nhat:" + So_max +
           "\nSo luong so duong:" + Slsd;
            Console.Write(chuoi);
            Console.ReadLine();*/

             int[] a;

             int[] b, c, d;

             Console.Write("So luong cac so nguyen cua a:");
             int n = int.Parse(Console.ReadLine());
             a = new int[n];
             for (int i = 0; i < n; i++)
             {
                 Console.Write("a[" + (i + 1) + "]=");
                 a[i] = int.Parse(Console.ReadLine());
             }

             b = a.Where(x => x < 0).ToArray();          
             c = a.Where(x => x % 2 == 0).ToArray();        
             d = a.Where(x => (x < 1 || x > 10)).ToArray();
             string chuoi = "Mang b: ";
             for (int i = 0; i < b.Length; i++)
                 chuoi += b[i] + " ";
             chuoi += "\nMang c: ";
             for (int i = 0; i < c.Length; i++)
                 chuoi += c[i] + " ";
             chuoi += "\nMang d: ";
             for (int i = 0; i < d.Length; i++)
                 chuoi += d[i] + " ";
             Console.Write(chuoi);
             Console.ReadLine();
            /*
              MAT_HANG[] Mh;

              double Dgtb;
              double Tong_tien;

              Console.Write("So luong mat hang:");
              int n = int.Parse(Console.ReadLine());
              Mh = new MAT_HANG[n];
              for (int i = 0; i < n; i++)
              {

              Console.Write((i + 1) + "\nTen hang:");
                  Mh[i].Ten_hang = Console.ReadLine();
                  Console.Write("So luong:");
                  Mh[i].So_luong = double.Parse(Console.ReadLine());
                  Console.Write("Don gia:");
                  Mh[i].Don_gia = double.Parse(Console.ReadLine());
              }

              Dgtb = Mh.Average(x => x.Don_gia);
              Tong_tien = Mh.Sum(x => x.Don_gia * x.So_luong);

              string chuoi = "Don gia trung binh cac mat hang:" +
             Math.Round(Dgtb, 1) + "\nTong tien tra:" + Tong_tien;
              Console.Write(chuoi);
              Console.ReadLine();
  */

        }
    }
}
