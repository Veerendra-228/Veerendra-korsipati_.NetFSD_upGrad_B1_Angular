using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class task2
{
    static void Main()
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            {1, new Student{Id=1, Name="Ram", Marks=80}},
            {2, new Student{Id=2, Name="Sita", Marks=70}},
            {3, new Student{Id=3, Name="John", Marks=90}},
            {4, new Student{Id=4, Name="Anu", Marks=60}},
            {5, new Student{Id=5, Name="Ravi", Marks=85}}
        };

     
        Console.WriteLine(students[3].Name);

    
        Console.WriteLine(students.ContainsKey(2));

      
        students[2].Marks = 75;

       
        students.Remove(4);

     
        var topStudents = students.Values.Where(s => s.Marks > 75);
        foreach (var s in topStudents)
            Console.WriteLine(s.Name);
    }
}