﻿using System;
using System.Text.RegularExpressions;
namespace regular_expression
{
    class Program
    {
       private static void showMatch(string text, string expr)
        {
            Console.WriteLine("Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa Regular Expression trong C#");
            Console.WriteLine("-----------------------------------------");

            string str = "Sao hom nay lai thay sao suyen son sang";

            Console.WriteLine("So khop voi cac tu bat dau bang chu cai 'S': ");
            showMatch(str, @"\bS\S*");
            Console.ReadKey();
    }
}
}