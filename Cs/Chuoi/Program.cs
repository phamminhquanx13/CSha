using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  string str; /* Khai bao mot chuoi */

            //Console.Write("\nNhap va in chuoi trong C#:\n");
            //Console.Write("-----------------------------------\n");
            //Console.Write("Nhap mot chuoi: ");
            //str = Console.ReadLine();
            //Console.Write("Ban vua nhap chuoi: {0}\n", str); 

            //Console.ReadKey();
          //  string str; /* Khai bao mot chuoi */
           /* int l = 0;

            Console.Write("\nTim do dai chuoi trong C#:\n");
            Console.Write("---------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Do dai chuoi la: {0}\n\n", l); 

            Console.ReadKey();*/
            // string str; /* Khai bao mot chuoi */
           // int bien_dem, l;

           //Console.Write("\nDem so tu trong mot chuoi trong C#:\n");
           // Console.Write("-------------------------------------\n");
            //Console.Write("Nhap mot chuoi: ");
           // str = Console.ReadLine();

            //l = 0;
           //bien_dem = 1;

            /* lap toi phan cuoi cua chuoi */
            //while (l <= str.Length - 1)
            //{
                /* kiem tra xem ky tu hien tai co phai la khoang trang 
                 * hay la ky tu new line hay ky tu tab */
             ///   if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
               // {
              //      bien_dem++;
               // }

              //  l++;
          //  }

           // Console.Write("Tong so tu co trong chuoi tren la: {0}\n", bien_dem);  

          //  Console.ReadKey();
         /* string str; //khai bao mot chuoi
            char[] arr1;
            char ch;
            int i, j, l;
            Console.Write("\nSap xep mang ky tu cua chuoi theo thu tu tang dan trong C#:\n");
            Console.Write("------------------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();
            l = str.Length;
            arr1 = str.ToCharArray(0, l);

            for (i = 1; i < l; i++)
                for (j = 0; j < l - i; j++)

                    if (arr1[j] > arr1[j + 1])
                    {
                        ch = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = ch;
                    }
            Console.Write("Sau khi sap xep, chuoi co dang: \n");
            foreach (char c in arr1)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine("\n");  
            */
            /*string str1; //Khai bao hai chuoi
            char[] arr1;
            int l, i;
            l = 0;
            char ch;
            Console.Write("\nChuyen chu hoa thanh chu thuong va nguoc lai trong C#:\n");
            Console.Write("--------------------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();
            l = str1.Length;
            arr1 = str1.ToCharArray(0, l); // chuyen chuoi thanh mang ky tu.  

            Console.Write("\nSau khi chuyen doi, chuoi co dang: ");
            for (i = 0; i < l; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch)) // kiem tra ky tu thuong  
                    Console.Write(Char.ToUpper(ch)); // chuyen doi chu thuong thanh chu hoa.  
                else
                    Console.Write(Char.ToLower(ch)); // chuyen doi chu hoa thanh chu thuong.  
            }
            Console.Write("\n\n"); 

            Console.ReadKey();*/
             /*Console.Write("\nKiem tra co phai la chu cai, sau do kiem tra chu hoa chu thuong trong C#\n");
            Console.Write("------------------------------------------------------------------------\n");
            Console.Write("Nhap mot ky tu: ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("\nKy tu vua nhap la chu hoa.\n");
                }
                else
                {
                    Console.WriteLine("\nKy tu vua nhap la chu thuong.\n");
                }
            }
            else
            {
                Console.WriteLine("\nKy tu vua nhap khong phai la chu cai.\n");
            }  

            Console.ReadKey();*/
             string str1, str2; //Khai bao hai chuoi
            bool m;

            Console.Write("\nKiem tra chuoi con trong C#:\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str1 = Console.ReadLine();

            Console.Write("Nhap chuoi con de kiem tra: ");
            str2 = Console.ReadLine();
            m = str1.Contains(str2); // ham nay tra ve gia tri boolean  
            if (m) // kiem tra true, false 
                Console.Write("Chuoi con co mat trong chuoi ban dau.\n\n");
            else
                Console.Write("Chuoi con khong co mat trong chuoi ban dau. \n\n");

            Console.ReadKey();

            string str; /* Khai bao mot chuoi */
            int l = 0;
/*
            Console.Write("\nIn cac ky tu rieng le cua chuoi theo chieu dao nguoc trong C#:\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Nhap mot chuoi: ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("In cac ky tu theo chieu dao nguoc: \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            Console.Write("\n\n"); 

            Console.ReadKey();*/
        }
        
    }
}
