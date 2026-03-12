using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo18
    {
        public void SameWordCheck()
        {
            Console.WriteLine("Enter First word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter Second word:");
            string word2 = Console.ReadLine();
            if (word1 == word2)
            {
                Console.WriteLine("Same Words");
            }
            else
            {
                Console.WriteLine("Different Words");
            }
        }
    }
}
