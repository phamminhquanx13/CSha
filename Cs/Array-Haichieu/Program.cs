﻿using System;

namespace Array_Haichieu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int i, j;
            int[,] arr1 = new int[3, 3];

            Console.Write("\nDoc va in mang hai chieu trong C#:\n");
            Console.Write("-----------------------------------\n");


            /* nhap cac phan tu vao trong mang
            Console.Write("Nhap cac phan tu vao trong mang hai chieu:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nIn mang hai chieu: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");       */
             /*int i, j, n;
            int[,] arr1 = new int[10, 10];

            Console.Write("\nIn ma tran tam giac tren trong C#:\n");
            Console.Write("-----------------------------------\n");

            Console.Write("Nhap kich co cua ma tran vuong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap cac phan tu vao trong ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("In ma tran ban dau:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("\nThiet lap cac phan tu nam duoi duong cheo chinh bang 0.\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    if (i <= j)
                        Console.Write("{0}  ", arr1[i, j]);
                    else
                        Console.Write("{0}  ", 0);
            }
            Console.Write("\n\n");   */ 
            /* int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] arr2 = new int[50, 50];
            int[,] ma_tran_tong = new int[50, 50];

            Console.Write("\nCong hai ma tran trong C#:\n");
            Console.Write("----------------------------\n");
            Console.Write("Nhap kich co cua hai ma tran vuong (nho hon 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Nhap cac phan tu vao trong mang da chieu*/
           /* Console.Write("Nhap cac phan tu vao trong ma tran dau tien:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Nhap cac phan tu vao trong ma tran thu hai:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nIn ma tran thu nhat:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }

            Console.Write("\nIn ma tran thu hai:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", arr2[i, j]);
            }
            /* cong hai ma tran 
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    ma_tran_tong[i, j] = arr1[i, j] + arr2[i, j];
            Console.Write("\nMa tran tong cua hai ma tran tren la: \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", ma_tran_tong[i, j]);
            }
            Console.Write("\n\n");       

            Console.ReadKey();
*/          
            int i, j, n;
            int[,] arr1 = new int[10, 10];

            Console.Write("\nIn ma tran tam giac tren trong C#:\n");
            Console.Write("-----------------------------------\n");

            Console.Write("Nhap kich co cua ma tran vuong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap cac phan tu vao trong ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("In ma tran ban dau:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("\nThiet lap cac phan tu nam duoi duong cheo chinh bang 0.\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    if (i <= j)
                        Console.Write("{0}  ", arr1[i, j]);
                    else
                        Console.Write("{0}  ", 0);
            }
            Console.Write("\n\n");     

            Console.ReadKey();
        }
    }
}
