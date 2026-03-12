using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo17
    {
        public void WordReverse()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            char[] ch = word.ToCharArray();
            Array.Reverse(ch);
            string reversed = new String(ch);
            Console.WriteLine("Reverse the word: "+reversed);
        }
    }
}
