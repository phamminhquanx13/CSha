using System;
using System.Linq;

namespace thu6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /*int Nm;
            int So_luong;
            Console.Write("Nhap vao nam:");
            Nm = int.Parse(Console.ReadLine());
            So_luong = 0;
            for (int Th = 1; Th <= 12; Th++)
            {
                DateTime Ng = new DateTime(Nm, Th, 13);
                if (Ng.DayOfWeek == DayOfWeek.Friday)
                    So_luong += 1;
            }
            string chuoi = "So luong thu sau ngay 13 cua nam:" +
           So_luong;
            Console.Write(chuoi);
            Console.ReadLine();
*/

            int Nm;
            DateTime[] Dsn = new DateTime[12];
            Console.Write("Nhap nam:");
            Nm = int.Parse(Console.ReadLine());
            for (int Th = 1; Th <= 12; Th++)
            {
                DateTime Ng = new DateTime(Nm, Th, 13);
                if (Ng.DayOfWeek == DayOfWeek.Friday)
                    Dsn[Th] = Ng;
            }
            DateTime[] Dsn_1 = Dsn.Where(x => x.DayOfWeek ==
           DayOfWeek.Friday && x.Day == 13 && x.Year == Nm).ToArray();
            string chuoi = "Danh sach thu sau ngay 13 cua nam\n";
            for (int i = 0; i < Dsn_1.Length; i++)
                chuoi += Dsn_1[i].ToLongDateString() + "\n";
            Console.Write(chuoi);
            Console.ReadLine();

        }
    }
}
