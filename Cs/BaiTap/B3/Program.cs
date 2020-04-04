using System;
using System.Text;
namespace B3
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string value1;
            string value2;
            string value3;

            Console.WriteLine("Nhập vào tuần tự 3 giá trị:");

            Console.WriteLine("Nhập vào giá trị thứ nhất");
            value1 = Console.ReadLine();

            Console.WriteLine("Nhập vào giá trị thứ hai");
            value2 = Console.ReadLine();

            Console.WriteLine("Nhập vào giá trị thứ ba");
            value3 = Console.ReadLine();

            Console.WriteLine(string.Format("Số {0}, Số {1} và Số {2}", value1,value2,value3));

            Console.ReadKey();
        }
    }
}
