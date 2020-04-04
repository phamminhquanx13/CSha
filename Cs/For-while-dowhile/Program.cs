using System;

namespace For_while_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("\n");
            Console.Write("In bang cuu chuong trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");
            int num, so_nhan;
            num = 2;

            do
            {
                so_nhan = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}",
                        num, so_nhan, num * so_nhan);
                    so_nhan++;
                }
                while (so_nhan <= 10);

                Console.WriteLine();
                num++;

            } while (num <= 9);        

            Console.ReadKey();
            /* 
             Console.Write("\n");
            Console.Write("Kiem tra so nguyen to trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            int number;
            int bien_dem = 0;

            Console.Write("Nhap mot so bat ky: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    bien_dem++;

            if (bien_dem == 2)
                Console.WriteLine("So da cho la so nguyen to.");
            else
                Console.WriteLine("So da cho khong phai la so nguyen to.");        

 int num, i, ctr, bat_dau, ket_thuc;

            Console.Write("\n\n");
            Console.Write("Tim so nguyen to trong C#:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so bat dau cua day: ");
            bat_dau = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua day: ");
            ket_thuc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cac so nguyen to trong day tu {0} toi {1} la: \n", bat_dau, ket_thuc);

            for (num = bat_dau; num <= ket_thuc; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");  
            */
            
        }
    }
}
