using System;

class Nurse
{
    public int NurseId { get; set; }
    public string NurseName { get; set; }
    public string Department { get; set; }
}

class assignment7
{
    static void Main()
    {
        Nurse n1 = new Nurse
        {
            NurseId = 1,
            NurseName = "Lakshmi",
            Department = "Emergency"
        };

        Console.WriteLine("Nurse Id: " + n1.NurseId);
        Console.WriteLine("Nurse Name: " + n1.NurseName);
        Console.WriteLine("Department: " + n1.Department);
    }
}