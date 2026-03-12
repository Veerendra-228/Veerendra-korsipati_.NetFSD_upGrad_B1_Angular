using System;
using System.Collections.Generic;
using System.Text;
class check
{
    static void Main(string[] args)
    {
        int number;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        NumberCheck obj = new NumberCheck();
        obj.CheckNumber(number);

        Console.ReadLine();
    }
}

