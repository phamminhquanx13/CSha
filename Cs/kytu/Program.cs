using System;

namespace kytu
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; //khai bao chuoi
            int chu_cai, chu_so, ky_tu_dac_biet, i, l;
            chu_cai = chu_so = ky_tu_dac_biet = i = 0;

            Console.Write("\nDem so chu cai, so chu so, so ky tu dac biet cua chuoi trong C#:\n");
            Console.Write("--------------------------------------------------------------------\n");
            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();
            l = str.Length;
            /* kiem tra tung ky tu trong chuoi*/
            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    chu_cai++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    chu_so++;
                }
                else
                {
                    ky_tu_dac_biet++;
                }
                i++;
            }
            Console.Write("So chu cai trong chuoi la: {0}\n", chu_cai);
            Console.Write("So chu so trong chuoi la: {0}\n", chu_so);
            Console.Write("So ky tu dac biet trong chuoi la: {0}\n\n", ky_tu_dac_biet);
            Console.ReadKey();
        }
    }
}
