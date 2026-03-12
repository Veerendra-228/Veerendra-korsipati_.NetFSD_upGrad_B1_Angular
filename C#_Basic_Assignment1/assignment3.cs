class Number
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, n5;

        Console.Write("Enter first number: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third number: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        n4 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        n5 = Convert.ToDouble(Console.ReadLine());

        NumberOperations obj = new NumberOperations();
        obj.Calculate(n1, n2, n3, n4, n5);

        Console.ReadLine();
    }
}