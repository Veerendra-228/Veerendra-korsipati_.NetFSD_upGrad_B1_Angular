using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo14
    {
        public void Smallest()
        {
            Console.WriteLine("Enter 5 Numbers");
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = num[0];
            for (int i = 0; i < 5; i++)
            {
                if (num[i] < smallest)
                {
                    smallest = num[i];
                }
            }
            Console.WriteLine("Smallest Number: ", +smallest);
        }
    }
}
