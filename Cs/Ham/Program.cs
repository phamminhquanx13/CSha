using System;

namespace Ham
{
    class Program
    {
          //tao ham tu dinh nghia welcome()
        public static void welcome()
        {
            Console.WriteLine("A!");
        }

        //tao ham tu dinh nghia HaveAnice
        public static void HaveAnice()
        {
            Console.WriteLine("B!");
        }
         static decimal TinhGiaiThua(int n1)
        {  
            if (n1 == 0)
            {
                return 1;
            }
            // Goi ham de qui: goi toi chinh ham nay 
            else
            {
                return n1 * TinhGiaiThua(n1 - 1);
            }
        }    
     public static void TraoDoiGiaTri(ref int num1, ref int num2)
        {
            int bien_tam;

            bien_tam = num1;
            num1 = num2;
            num2 = bien_tam;
        }
        static void Main(string[] args)
        {
           /*  Console.Write("\nCach tao ham tu dinh nghia trong C#:\n");
            Console.Write("-------------------------------------\n");
            //goi hai ham tu dinh nghia
            welcome();
            HaveAnice();
            Console.Write("\n");*/
            int n1, n2;
            Console.Write("\nTao ham tu dinh nghia de trao doi gia tri trong C#:\n");
            Console.Write("----------------------------------------------------\n");
            Console.Write("Nhap so thu nhat: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            //goi ham tu dinh nghia
            TraoDoiGiaTri(ref n1, ref n2);
            Console.WriteLine("\nSau khi trao doi gia tri:");
            Console.WriteLine("Gia tri cua so thu nhat la: {0}\nGia tri cua so thu hai la: {1}", n1, n2);
              decimal f;
            Console.Write("\nTao ham de qui de tinh giai thua trong C#:\n");
            Console.Write("-------------------------------------------\n");
            Console.Write("Nhap mot so: ");
            int num = Convert.ToInt32(Console.ReadLine());
            f = TinhGiaiThua(num);
            Console.WriteLine("Giai thua cua {0}! la {1}", num, f);
        }
    }
}
