class Program
{
    static void Main(string[] args)
    {
        double num1, num2;

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Division obj = new Division();
        double quotient = obj.DivideNumbers(num1, num2);

        Console.WriteLine("Quotient = " + quotient);

        Console.ReadLine();
    }
}