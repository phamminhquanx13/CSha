using System;

namespace Struct

{
    struct A
    {
        public int x;
        public int y;
    }
    class Program
    {
        struct nhanVien
        {
            public string eName;
            public ngaySinh Date;
        }
        //khai bao cau truc ngaySinh 
        struct ngaySinh
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            Console.Write("\nKhai bao struct trong C#:\n");
            Console.Write("---------------------------\n");
            A q = new A();
            q.x = 15;
            q.y = 25;
            int sum = q.x + q.y;
            Console.WriteLine("Tong cua x va y la {0}\n", sum);

            Console.ReadKey();
             int dd = 0, mm = 0, yy = 0;
            int total = 2;
            Console.Write("\nLong struct trong C#:\n");
            Console.Write("--------------------------\n");
            nhanVien[] emp = new nhanVien[total];

            for (int i = 0; i < total; i++)
            {
                Console.Write("Ten nhan vien: ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Nhap ngay sinh: ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;

                Console.Write("Nhap thang sinh: ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;

                Console.Write("Nhap nam sinh: ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
            Console.ReadKey();
        }
        
    }
}
