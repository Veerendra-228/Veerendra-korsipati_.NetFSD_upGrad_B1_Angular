using System;
using System.Collections.Generic;

class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Disease { get; set; }
}

class task5
{
    static void Main()
    {
        Queue<Patient> queue = new Queue<Patient>();

        queue.Enqueue(new Patient { Id = 1, Name = "A", Disease = "Fever" });
        queue.Enqueue(new Patient { Id = 2, Name = "B", Disease = "Cold" });
        queue.Enqueue(new Patient { Id = 3, Name = "C", Disease = "Injury" });
        queue.Enqueue(new Patient { Id = 4, Name = "D", Disease = "Cough" });
        queue.Enqueue(new Patient { Id = 5, Name = "E", Disease = "Flu" });

      
        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine("Next: " + queue.Peek().Name);

        foreach (var p in queue)
            Console.WriteLine(p.Name);
    }
}