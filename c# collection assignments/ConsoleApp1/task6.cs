using System;
using System.Collections.Generic;

class Song
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }
}

class task6
{
    static void Main()
    {
        LinkedList<Song> playlist = new LinkedList<Song>();

        var s1 = new Song { Id = 1, Title = "Song1", Artist = "A" };
        var s2 = new Song { Id = 2, Title = "Song2", Artist = "B" };
        var s3 = new Song { Id = 3, Title = "Song3", Artist = "C" };

        playlist.AddFirst(s1);
        playlist.AddLast(s2);
        playlist.AddAfter(playlist.First, s3);

       
        foreach (var s in playlist)
            Console.WriteLine(s.Title);

        
        playlist.Remove(s2);

       
        var found = playlist.Find(s3);
        Console.WriteLine("Found: " + found.Value.Title);

     
        var node = playlist.Last;
        while (node != null)
        {
            Console.WriteLine(node.Value.Title);
            node = node.Previous;
        }

        var current = playlist.First;
        Console.WriteLine("Playing: " + current.Value.Title);
        Console.WriteLine("Next: " + current.Next?.Value.Title);
    }
}