using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace huongdoituong
{
    class Person
    {
        protected int age;
        public void LoiChao()
        {
            Console.WriteLine("A");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
}