using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo8
    {
        public void Series()
        {
            int[] nums = new int[26];
            for (int i=0; i <= 25; i++)
            {
                nums[i] = i * i;
            }
            Console.WriteLine(String.Join(",",nums));
        }
    }
}
