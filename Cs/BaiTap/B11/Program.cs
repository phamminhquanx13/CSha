using System;
using System.Text;
namespace B11
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            /*
            if (a > b)
            {
                Console.WriteLine(string.Format("{0} lớn hơn {1}", a,b));
            }
            else if (a < b)
            {
                Console.WriteLine(string.Format("{0} nhỏ hơn {1}", a, b));
            }
            else
            {
                Console.WriteLine(string.Format("{0} bằng {1}", a, b));
            }
            */

            switch(a > b)
            {
                case true:
                    Console.WriteLine(string.Format("{0} lớn hơn {1}", a, b));
                    break;
                case false:
                    switch (a < b)
                    {
                        case true:
                            Console.WriteLine(string.Format("{0} nhỏ hơn {1}", a, b));
                            break;
                        default:
                            Console.WriteLine(string.Format("{0} bằng {1}", a, b));
                            break;
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
    }

