using System;
using System.Text;
namespace B15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Ngày: ");
            int day = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tháng: ");
            int month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Năm: ");
            int year = Int32.Parse(Console.ReadLine());

            DateTime date = new DateTime(year,month,day);            

            Console.WriteLine(date.DayOfWeek);

            Console.ReadKey();
        }
    
    }
}
