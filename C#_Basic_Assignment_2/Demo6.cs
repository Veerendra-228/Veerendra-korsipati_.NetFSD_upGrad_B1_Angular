using System;
using System.Collections.Generic;
using System.Text;

namespace C__Basic_Assignment_2
{
    internal class Demo6
    {
        public void DisplayTemperature()
        {
            Console.WriteLine("Enter Temperature in Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: " + c);
        }
    }
}
