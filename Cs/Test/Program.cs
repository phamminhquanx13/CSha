using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           /*int i, n, sum = 0;
            Console.Write("\n");
            Console.Write("Hien thi va tinh tong n so le trong C#:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so cac so: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHien thi cac so le: ");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nTong {0} so le ban dau la: {1} \n", n, sum);          

              int i, j, so_hang;
            Console.Write("\n");
            Console.Write("Ve tam giac sao trong C#:\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
                
            }   
              int i, j, so_hang;

            Console.Write("\n");
            Console.Write("Ve tam giac so trong C#:\n");
            Console.Write("--------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= so_hang; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);
                Console.Write("\n");
            }            

            Console.ReadKey();      
             int i, j, bien_dem, so_hang, k;

            Console.Write("\n");
            Console.Write("Ve tam giac sao deu trong C#:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            bien_dem = so_hang + 4 - 1;
            for (i = 1; i <= so_hang; i++)
            {
                for (k = bien_dem; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                bien_dem--;
            }                

            Console.ReadKey();   
            
            
            int n1, n, p = 1;
            int dec = 0, i = 1, j, d;

            Console.Write("\n");
            Console.Write("Chuyen doi nhi phan thanh thap phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap mot so bat ky trong he nhi phan: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            for (j = n; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                dec = dec + (d * p);
                i++;
            }
            Console.Write("\nSo trong he nhi phan: {0}\nSo thap phan tuong duong la: {1} \n\n", n1, dec);

            Console.ReadKey();
            */
            int n, i, j, ocno = 0, dn;

            Console.Write("\n");
            Console.Write("Chuyen doi thap phan thanh bat phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;

            for (j = n; j > 0; j = j / 8)
            {
                ocno = ocno + (j % 8) * i;
                i = i * 10;
                n = n / 8;
            }

            Console.Write("\nSo tuong duong trong he Octal cua so {0} la {1}.\n\n", dn, ocno);   

            Console.ReadKey();
        }
    }
}
