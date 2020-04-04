using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] arr = new int[10];
            int i;
            Console.Write("\nDoc va in cac phan mang trong C#:\n");
            Console.Write("----------------------------------\n");

            Console.Write("Nhap 10 phan tu mang:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nIn cac phan tu mang: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");      

            Console.ReadKey();
            int[] a = new int[100];
            int i, n, sum = 0;


            Console.Write("\nTim tong cac phan tu mang trong C#:\n");
            Console.Write("------------------------------------\n");

            Console.Write("Nhap so phan tu can luu tru vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang: \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Tong cac phan tu trong mang la: {0}\n\n", sum);      

            Console.ReadKey();*/
            /*
             int[] arr1 = new int[100]; //day la mang ban dau
            int[] arr2 = new int[100]; //day la mang sao
            int i, n;


            Console.Write("\nSao chep mang trong C#:\n");
            Console.Write("------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* sao chep cac phan tu trong mang arr1 vao trong mang arr2.
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            /* in cac phan tu trong mang arr1  
            Console.Write("\nCac phan tu trong mang ban dau la:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            /* in cac phan tu trong mang arr2. 
            Console.Write("\n\nCac phan tu trong mang sao la:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");       

            Console.ReadKey();
            */
           /* int[] arr1 = new int[100];
            int i, mx, mn, n;


            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);       

            Console.ReadKey();*/
           /* int[] arr1 = new int[10];
            int n, i, j, tmp; // tmp duoc su dung lam bien tam (bien trung gian)


            Console.Write("\nSap xep mang theo thu tu tang dan trong C#:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nIn cac phan tu mang theo thu tu tang dan:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");      

            Console.ReadKey();*/

            int i, pos, n; //pos la vi tri can xoa
            int[] arr1 = new int[50];


            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
            /* xac dinh vi tri cua i trong mang*/
            i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no */
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");      

            Console.ReadKey();
            
        }
    }
}
