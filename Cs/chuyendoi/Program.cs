using System;

namespace chuyendoi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n1, n, p = 1;
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

          Console.ReadKey();*/
            /*
             int n1, n;
            double dec = 0, i = 0, d;

            Console.Write("\n");
            Console.Write("Chuyen doi nhi phan thanh thap phan trong C# (su dung ham):\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so trong he nhi phan: ");
            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            while (n != 0)
            {
                d = n % 10;
                dec = dec + d * Math.Pow(2, i); // su dung ham trong C#
                n = n / 10;
                i++;
            }
            Console.Write("\nSo trong he nhi phan: {0}\nSo thap phan tuong duong la: {1}\n\n", n1, dec);

            Console.ReadKey();*/
            /*
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

            Console.ReadKey();*/
            /*
             int n, i, j, binno = 0, dn;
            Console.Write("\n");
            Console.Write("Chuyen doi thap phan thanh nhi phan trong C#:\n");
            Console.Write("--------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap mot so thap phan bat ky: ");
            n = Convert.ToInt32(Console.ReadLine());
            dn = n;
            i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                binno = binno + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.Write("\nSo trong he nhi phan tuong duong cua so {0} la {1}.\n\n", dn, binno);  

            Console.ReadKey();
            */
             int n1, n5, p = 1;
            int dec = 0, i = 1, j, d;
            int binno = 0;

            Console.Write("\n");
            Console.Write("Chuyen doi bat phan thanh nhi phan trong C#:\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Nhap mot so trong he bat phan (su dung cac chu so 0 - 7): ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n5 = n1;

            for (j = n1; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 8;

                dec = dec + (d * p);
                i++;
            }

            /*------------------------------------------------------------------------------*/
            i = 1;

            for (j = dec; j > 0; j = j / 2)
            {
                binno = binno + (dec % 2) * i;
                i = i * 10;
                dec = dec / 2;
            }

            Console.Write("\nSo trong he bat phan: {0}\nSo tuong duong trong he nhi phan la: {1} \n\n", n5, binno);  

            Console.ReadKey();
            
        }
    }
}
