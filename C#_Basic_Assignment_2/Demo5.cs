using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo5
    {
        public void DisoplaySum()
        {
            
            Console.WriteLine("Enter a Number to Enter Numbers:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] nums=new int[num];
            int evenSum = 0; 
            int oddSum = 0;
            for (int i = 0; i <num; i++)
            {
                Console.WriteLine("Enter a number:");
                nums[i] = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine(string.Join(",", nums));
            for (int i = 0; i < num; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenSum += nums[i];
                    
                }
                else
                {
                    oddSum += nums[i];
                    
                }
            }
            Console.WriteLine("EvenSum: " + evenSum);
            Console.WriteLine("OddSum: " + oddSum);
        }
    }
}
