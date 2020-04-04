using System;

namespace chuoi_dao_nguoc
{
    class Program
    {
        static void Main(string[] args)
        { 
           /* string str, str1 = "";
            int i, l;

            Console.Write("\n");
            Console.Write("In chuoi theo chieu dao nguoc trong C#:\n");
            Console.Write("-------------------------------------");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];
            }
            Console.WriteLine("Chuoi dao nguoc cua chuoi ban dau la: {0}", str1);
            Console.Write("\n"); 
            Console.ReadKey();*/
             int i, n1, n2, j, uscln = 1;
            Console.Write("\n");
            Console.Write("Tim uoc so chung lon nhat trong C#:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            j = (n1 < n2) ? n1 : n2;
            for (i = 1; i <= j; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    uscln = i;
                }
            }
            Console.Write("\nUSCLN cua {0} va {1} la: {2}\n\n", n1, n2, uscln);

            Console.ReadKey();
        }
    }
}
