using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo13
    {
        public void Largest()
        {
            Console.WriteLine("Enter 3 Numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine(a + " is Largest");
                }
                else
                {
                    Console.WriteLine(c + "is Largest");
                }
            }
            else 
            {
                if (b >= c)
                {
                    Console.WriteLine(b + " is Largest");
                }
                else
                {
                    Console.WriteLine(c + " is Largest");
                }
            }
        }
    }
}
