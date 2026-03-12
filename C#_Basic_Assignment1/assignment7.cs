class journey
{
    static void Main(string[] args)
    {
        double distance, speed;

        Console.Write("Enter distance: ");
        distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter speed: ");
        speed = Convert.ToDouble(Console.ReadLine());

        Journey obj = new Journey();
        obj.CalculateTime(distance, speed);

        Console.ReadLine();
    }
}