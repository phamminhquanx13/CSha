using System;
using System.Linq;

namespace tongdauvacuoin
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            int S;
            Console.Write("Nhap so duong n:");
            n = int.Parse(Console.ReadLine());
            S = 0;
            while (n > 0)
            {
                int So_cuoi = n % 10;
                S += So_cuoi;
                n /= 10;
            }
            string chuoi = "Tong cac chu so la:" + S;
            Console.Write(chuoi);
            Console.ReadLine();
            /*
            int n;
            int Slcs;
            Console.Write("Nhap so duong n:");
            n = int.Parse(Console.ReadLine());
            Slcs = 0;
            //while(n>0)
            //{
            // Slcs += 1;
            // n = n / 10;
            //}
            do
            {
                Slcs += 1;
                n = n / 10;
            } while (n > 0);
            string chuoi = "So luong so chu so:" + Slcs;
            Console.Write(chuoi);
            Console.ReadLine();

            int[] a;
            bool Kq = true;
            Console.Write("So luong cac so cua mang a:");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)

            {
                Console.Write("a[" + (i + 1) + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = a.Where(x => x >= 1 && x <= n).ToArray();
            if (b.Length == n)
                Kq = true;
            else if (b.Length < n)
                Kq = false;
            string chuoi = "Ket qua kiem tra mang a:" + Kq;
            Console.Write(chuoi);
            Console.ReadLine();*/

        }
    }
}
