using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo4
    {
        public void DisplayEvenorOdd()
        {
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is Even");
            }
            else
            {
                Console.WriteLine(n + " is Odd");
            }
        }
    }
}
