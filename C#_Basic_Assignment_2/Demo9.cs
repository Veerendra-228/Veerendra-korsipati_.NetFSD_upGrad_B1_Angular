using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo9
    {
        public static int Fact(int n)
        {
            int num = 1;
            for (int i = 2; i <= n; i++)
            {
                num = num * i;
            }
            return num;
        }
        public void Factorial()
        {
            Console.WriteLine("Enter a Number to Find Factorial:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial of "+n+" is "+Fact(n));
        }
    }
}
