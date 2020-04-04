using System;

namespace kiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
           string username, password; //khai bao hai chuoi
            int ctr = 0;
            Console.Write("\nKiem tra username va password trong C#:\n");
            Console.Write("Mac dinh username va password la:\n");
            Console.Write("------------------------------------------------------\n");

            do
            {
                Console.Write("Nhap username: ");
                username = Console.ReadLine();

                Console.Write("Nhap password: ");
                password = Console.ReadLine();

                if (username != "quan1" || password != "1234")
                    ctr++;
                else
                    ctr = 1;

            }
            while ((username != "quan1" || password != "1234") && (ctr != 3));

            if (ctr == 3)
                Console.Write("\nBan da nhap sai username va password qua 3 lan. Xin hay thu lai!\n\n");
            else
                Console.Write("\nBan da nhap mat khau dung!\n\n");

            Console.ReadKey();
        }
    }
}
