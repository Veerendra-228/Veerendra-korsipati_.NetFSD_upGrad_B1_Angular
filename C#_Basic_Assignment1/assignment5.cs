using System;
using System.Collections.Generic;
using System.Text;

class highest
{
    static void Main(string[] args)
    {
        int num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        HighestNumber obj = new HighestNumber();
        obj.NumberHighest(num1, num2);

        Console.ReadLine();
    }
}


