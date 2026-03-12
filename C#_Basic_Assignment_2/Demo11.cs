using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo11
    {
        public void MultiplicationTable()
        {
            Console.WriteLine("Enter Number for Multiplication table:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i} X {num} = {i * num}");
            }
        }
    }
}
