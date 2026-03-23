using System;
using System.IO;

class StudentReportCard
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Report Card System ---");
            Console.WriteLine("1. Create Report");
            Console.WriteLine("2. View Report");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateReport();
                    break;
                case 2:
                    ViewReport();
                    break;
            }

        } while (choice != 3);
    }

    static void CreateReport()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();

            int m1 = GetValidMarks("Subject 1");
            int m2 = GetValidMarks("Subject 2");
            int m3 = GetValidMarks("Subject 3");

            int total = m1 + m2 + m3;
            double average = total / 3.0;

            string grade;

            if (average >= 80)
                grade = "A";
            else if (average >= 60)
                grade = "B";
            else if (average >= 40)
                grade = "C";
            else
                grade = "Fail";

            string content =
$@"Student Name: {name}
Roll Number: {roll}
Marks: {m1}, {m2}, {m3}
Total: {total}
Average: {average:F2}
Grade: {grade}";

            File.WriteAllText($"{roll}.txt", content);

            Console.WriteLine("Report generated successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ViewReport()
    {
        try
        {
            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine();

            string filePath = $"{roll}.txt";

            if (File.Exists(filePath))
            {
                string data = File.ReadAllText(filePath);
                Console.WriteLine("\n--- Report ---");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Report not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static int GetValidMarks(string subject)
    {
        int marks;

        while (true)
        {
            Console.Write($"Enter marks for {subject} (0-100): ");
            bool isValid = int.TryParse(Console.ReadLine(), out marks);

            if (isValid && marks >= 0 && marks <= 100)
                return marks;

            Console.WriteLine("Invalid input! Try again.");
        }
    }
}