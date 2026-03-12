using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo19
    {
        public void Palindrome()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            string word1 = word;
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reverseWord = new string(charArray);
            if (word1 == reverseWord)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }
    }
}
