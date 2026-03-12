using System;

// Class for division operation
class Division
{
    public double DivideNumbers(double num1, double num2)
    {
        return num1 / num2;
    }
}


// Class for conversion
class DistanceConverter
{
    public double KmToMeters(double km)
    {
        return km * 1000;
    }
}

class NumberOperations
{
    public void Calculate(double n1, double n2, double n3, double n4, double n5)
    {
        double sum = n1 + n2 + n3 + n4 + n5;
        double average = sum / 5;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);
    }
}

class NumberCheck
{
    public void CheckNumber(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("The number is Even");
        }
        else
        {
            Console.WriteLine("The number is Odd");
        }
    }
}
class HighestNumber
{
    public void NumberHighest(int num1, int num2)
    {
        if (num1>num2)
        {
            Console.WriteLine("The highest number is " + num1);
        }
        else
        {
            Console.WriteLine("The highest number is " + num2);
        }
    }
}

// Class to calculate areas
class AreaCalculator
{
    public void RectangleArea(double length, double breadth)
    {
        double area = length * breadth;
        Console.WriteLine("Area of Rectangle = " + area);
    }

    public void SquareArea(double side)
    {
        double area = side * side;
        Console.WriteLine("Area of Square = " + area);
    }
}

// Class to calculate time
class Journey
{
    public void CalculateTime(double distance, double speed)
    {
        double time = distance / speed;
        Console.WriteLine("Time taken for the journey = " + time + " hours");
    }
}

// Class to check vowel or consonant
class CharacterCheck
{
    public void CheckThirdCharacter(string str)
    {
        if (str.Length >= 3)
        {
            char ch = char.ToLower(str[2]);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("The third character is a Vowel");
            }
            else
            {
                Console.WriteLine("The third character is a Consonant");
            }
        }
        else
        {
            Console.WriteLine("String must contain at least 3 characters.");
        }
    }
}



