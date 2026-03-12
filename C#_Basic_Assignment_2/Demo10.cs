using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo10
    {
        
        public void Fibonacci()
        {
            int a = 0, b = 1, temp;
            while(a<=40)
            {
                Console.WriteLine(a);
                temp = a;
                a = a + b;
                b = temp;
                
            }
        }
    }
}
