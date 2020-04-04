using System;

namespace Dahinh
{
    class Program
    {
        /* abstract class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine(" Animal is speaking. . .");
            }
        }
*/
        abstract class Animal
        {
            /*
                Khai báo phương thức thuần ảo nên không cần định nghĩa nội dung cho phương thức
             */

            public abstract void Speak();

        }


        class Cat : Animal
        {
            public override void Speak()
            {
                Console.WriteLine(" Cat is speaking. . .");
            }
        }


        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine(" Dog is speaking. . .");
            }
        }
        static void Main(string[] args)
        {
            Animal cat = new Cat();

            Animal dog = new Dog();
            cat.Speak();
            dog.Speak();

        }
    }
}
