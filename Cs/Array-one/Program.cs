using System;

namespace Array_one
{
    class Program
    {
        static void Main(string[] args)
        {
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
            /*
            int[] arr1 = new int[10];
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
int[] arr1 = new int[10];
            int i, n, p = 0, phan_tu_moi;
            Console.Write("\nChen phan tu vao mang trong C#:\n");
            Console.Write("--------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap gia tri phan tu can chen: ");
            phan_tu_moi = Convert.ToInt32(Console.ReadLine());
            Console.Write("In mang truoc khi chen:\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            /* xac dinh vi tri de chen phan tu moi.
            for (i = 0; i < n; i++)
                if (phan_tu_moi < arr1[i])
                {
                    p = i;
                    break;
                }
            /* di chuyen vi tri tat ca phan tu ben canh phai cua mang 
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* chen phan tu moi vao vi tri thich hop 
            arr1[p] = phan_tu_moi;

            Console.Write("\n\nSau khi chen, mang co cac phan tu:\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n");    

            Console.ReadKey();
            
            int i, pos, n; //pos la vi tri can xoa
            int[] arr1 = new int[50];


            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
            /* xac dinh vi tri cua i trong mang
            i = 0;
            while (i != pos - 1)
                i++;
            /*vi tri i trong mang se duoc thay the boi gia tri ben phai cua no 
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

            
            int[] arr1 = new int[10];
            int[] arr2 = new int[10]; // mang chua cac phan tu chan
            int[] arr3 = new int[10]; // mang chua cac phan tu le
            int i, j = 0, k = 0, n;


            Console.Write("\nChia mang thanh mang chan, mang le trong C#:\n");
            Console.Write("---------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nCac phan tu chan la: \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nCac phan tu le la:\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");      

            Console.ReadKey();
           */
           
        }
    }
}
