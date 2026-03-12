class area
{
    static void Main(string[] args)
    {
        double length, breadth, side;

        Console.Write("Enter length of rectangle: ");
        length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        breadth = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side of square: ");
        side = Convert.ToDouble(Console.ReadLine());

        AreaCalculator obj = new AreaCalculator();
        obj.RectangleArea(length, breadth);
        obj.SquareArea(side);

        Console.ReadLine();
    }
}