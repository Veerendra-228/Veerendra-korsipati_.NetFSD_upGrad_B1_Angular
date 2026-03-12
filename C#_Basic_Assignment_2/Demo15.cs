using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo15
    {
        public void Calculation()
        {
            int total = 0, max=0, min=0;
            int[] marks = new int[10];
            double average = 0.0;
            Console.WriteLine("Enter 10 Marks:");
            for (int i = 0; i < 10; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                total += marks[i];
                if (max < marks[i])
                {
                    max = marks[i];
                }
                if (min > marks[i])
                {
                    min = marks[i];
                }
            }
            Console.WriteLine("Total: " + total);
            average = total / 10;
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Maxium Marks: " + max);
            Console.WriteLine("Minimum Marks: " + min);
            Array.Sort(marks);
            Console.WriteLine("Ascending Order");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Array.Reverse(marks);
            Console.WriteLine("Desending Order");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
