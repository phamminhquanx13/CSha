using System;

namespace Shell_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
              int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n;

            n = arr.Length;
            Console.WriteLine("Shell Sort trong C#");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("In mang ban dau:");
            in_cac_phan_tu_mang(arr);
            shellSort(arr, n);
            Console.WriteLine("\nIn mang da qua sap xep:");
            in_cac_phan_tu_mang(arr);

            Console.ReadKey();
        }
        static void shellSort(int[] arr, int kich_co_mang)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < kich_co_mang; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        static void in_cac_phan_tu_mang(int[] arr)
        {
            foreach (var phan_tu in arr)
            {
                Console.Write(phan_tu + " ");
            }
            Console.Write("\n");
        }  
    }
}
