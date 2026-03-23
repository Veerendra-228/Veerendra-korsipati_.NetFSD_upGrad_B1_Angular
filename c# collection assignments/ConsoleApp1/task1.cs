using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop", Price=50000, Category="Electronics"},
            new Product{Id=2, Name="Mobile", Price=15000, Category="Electronics"},
            new Product{Id=3, Name="Shoes", Price=2000, Category="Fashion"},
            new Product{Id=4, Name="Watch", Price=3000, Category="Accessories"},
            new Product{Id=5, Name="Bag", Price=1200, Category="Fashion"},
            new Product{Id=6, Name="Keyboard", Price=800, Category="Electronics"},
            new Product{Id=7, Name="Mouse", Price=500, Category="Electronics"},
            new Product{Id=8, Name="Chair", Price=2500, Category="Furniture"},
            new Product{Id=9, Name="Table", Price=7000, Category="Furniture"},
            new Product{Id=10, Name="Headphones", Price=1800, Category="Electronics"}
        };

        Console.WriteLine("All Products:");
        products.ForEach(p => Console.WriteLine($"{p.Name} - {p.Price}"));

        Console.WriteLine("\nPrice > 1000:");
        var costly = products.Where(p => p.Price > 1000);
        foreach (var p in costly)
            Console.WriteLine(p.Name);

        Console.WriteLine("\nAscending:");
        var asc = products.OrderBy(p => p.Price);
        foreach (var p in asc)
            Console.WriteLine(p.Name);

        Console.WriteLine("\nDescending:");
        var desc = products.OrderByDescending(p => p.Price);
        foreach (var p in desc)
            Console.WriteLine(p.Name);

        // Remove by Id
        products.RemoveAll(p => p.Id == 5);

        // Bonus: Filter by category
        var electronics = products.Where(p => p.Category == "Electronics");
        Console.WriteLine("\nElectronics:");
        foreach (var p in electronics)
            Console.WriteLine(p.Name);
    }
}
