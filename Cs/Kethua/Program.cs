using System;

namespace Kethua
{
    class Animal
    {
        protected double Weight;
        protected double Height;
        protected static int Legs;

        public void Info()
        {
            Console.WriteLine(" Weight: " + Weight + " Height: " + Height + " Legs: " + Legs);
        }
    }


    class Cat : Animal
    {
        public Cat()
        {
            /*
                Lớp Cat kế thừa lớp Animal
                mà các thuộc tính Weight, Height, Legs có phạm vi là protected nên được phép kế thừa
                Từ đó lớp Cat có thể sử dụng mà không cần phải khai báo

             */
            Weight = 500;
            Height = 20;
            Legs = 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Cat BlackCat = new Cat();

            /* Lớp Cat kế thừa phương thức Info từ lớp Animal nên đối tượng thuộc lớp Cat có thể gọi phương thức Info() */

            BlackCat.Info();
        }
    }
}
