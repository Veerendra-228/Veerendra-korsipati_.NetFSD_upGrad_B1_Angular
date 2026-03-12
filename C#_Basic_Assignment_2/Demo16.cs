using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo16
    {
        public void LengthofWord()
        
        {
            Console.WriteLine("Enter a Word:");
            string word = Console.ReadLine();
            int length = word.Length;
            Console.WriteLine("Length of word"+length);
        }
    }
}
