using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace C__Basic_Assignment_2
{
    internal class Demo7
    {
        public void Products()
        {
            double totalRetailValue = 0.0;

            Console.WriteLine("Enter product number and quality sold.");
            Console.WriteLine("Enter 0 as product number to stop");

            while (true)
            {
                Console.Write("Enter Product Number: ");
                int productNumber = Convert.ToInt32(Console.ReadLine());
                if (productNumber == 0)
                    break;
                Console.Write("Enter Quantity sold: ");
                int quntitySold = Convert.ToInt32(Console.ReadLine());
                double price = 0.0;
                switch (productNumber)
                {
                    case 1:
                        price = 22.5;
                        break;
                    case 2:
                        price = 44.50;
                        break;
                    case 3:
                        price = 9.98;
                        break;
                    default:
                        Console.WriteLine("Invalid Product Number");
                        continue;
                }
                totalRetailValue += price * quntitySold;
            }
            Console.WriteLine("Total Retail Value: "+totalRetailValue);
        }
    }
}
