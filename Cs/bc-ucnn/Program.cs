using System;

namespace bc_ucnn
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i, n1, n2, j, hcf = 1, bscnn;
            Console.Write("\n");
            Console.Write("Tim boi so chung nho nhat trong C# (su dung USCLN):\n");
            Console.Write("--------------------------------------------------");
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
                    hcf = i;
                }
            }
            /* chung ta biet rang: tich cua uoc so chung lon nhat va boi 
            so chung nho nhat thi bang tich cua hai so.*/
           /* bscnn = (n1 * n2) / hcf;

            Console.Write("\nBSCNN cua {0} va {1} la: {2}\n\n", n1, n2, bscnn);

            Console.ReadKey();*/
             int i, n1, n2, max, bscnn = 1;
            Console.Write("\n");
            Console.Write("Tim boi so chung nho nhat trong C# (khong su dung USCLN):\n");
            Console.Write("-------------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            max = (n1 > n2) ? n1 : n2;
            for (i = max; ; i += max)
            {
                if (i % n1 == 0 && i % n2 == 0)
                {
                    bscnn = i;
                    break;
                }
            }
            Console.Write("\nBSCNN cua {0} va {1} = {2}\n\n", n1, n2, bscnn); 

            Console.ReadKey();
        }
    }
}
