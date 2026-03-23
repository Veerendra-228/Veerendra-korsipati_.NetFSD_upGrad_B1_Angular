using System;
using System.Collections.Generic;
using System.Linq;

class task3
{
    static void Main()
    {
        HashSet<string> emails = new HashSet<string>()
        {
            "a@gmail.com", "b@gmail.com", "c@gmail.com",
            "a@gmail.com", "d@gmail.com", "e@gmail.com",
            "f@gmail.com", "g@gmail.com", "h@gmail.com",
            "b@gmail.com"
        };

        Console.WriteLine("Unique Emails:");
        foreach (var e in emails)
            Console.WriteLine(e);

        Console.WriteLine(emails.Contains("a@gmail.com"));

        emails.Remove("d@gmail.com");

      
        HashSet<string> event2 = new HashSet<string>()
        {
            "a@gmail.com", "x@gmail.com"
        };

        event2.IntersectWith(emails);
        Console.WriteLine("Common:");
        foreach (var e in event2)
            Console.WriteLine(e);
    }
}