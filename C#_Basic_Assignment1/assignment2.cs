class Converter
{
    public static void Main(string[] args)
    {
        double kilometers;

        Console.Write("Enter distance in kilometers: ");
        kilometers = Convert.ToDouble(Console.ReadLine());

        DistanceConverter obj = new DistanceConverter();
        double meters = obj.KmToMeters(kilometers);

        Console.WriteLine("Distance in meters = " + meters);

        Console.ReadLine();
    }
}
