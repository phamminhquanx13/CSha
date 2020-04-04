using System;
using System.Text;

namespace B2
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời nhập dữ liệu: ");
            string s;
            s = Console.ReadLine();
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
