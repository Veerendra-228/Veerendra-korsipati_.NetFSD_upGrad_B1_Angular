using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo3
    {
        public void DisplayNumbers()
        {
            Console.WriteLine("Enter Stating Number:");
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending Number");
            int en = Convert.ToInt32(Console.ReadLine());
            for (int i = sn; i <= en; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
