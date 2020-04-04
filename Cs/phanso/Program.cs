using System;

namespace phanso
{
    class Program
    {
        struct PHAN_SO
        {
            public int Tu_so, Mau_so;
        }
        static void Main(string[] args)
        {

            PHAN_SO x, y;

            PHAN_SO z;

            Console.Write("Phan so x\nTu so=");
            x.Tu_so = int.Parse(Console.ReadLine());
            Console.Write("Mau so=");
            x.Mau_so = int.Parse(Console.ReadLine());
            Console.Write("Phan so y\nTu so=");
            y.Tu_so = int.Parse(Console.ReadLine());
            Console.Write("Mau so=");
            y.Mau_so = int.Parse(Console.ReadLine());

            z.Tu_so = x.Tu_so * y.Tu_so;
            z.Mau_so = x.Mau_so * y.Mau_so;



            string chuoi = "Phan so z=x*y=" + z.Tu_so + "/" + z.Mau_so;
            Console.Write(chuoi);
            Console.ReadLine();

        }
    }
}
