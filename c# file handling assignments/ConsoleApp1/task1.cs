using System;
using System.IO;
using System.Collections.Generic;

class EmployeeLogSystem
{
    static string filePath = "employee_log.txt";

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Employee Log System ---");
            Console.WriteLine("1. Add Login Entry");
            Console.WriteLine("2. Update Logout Time");
            Console.WriteLine("3. View Logs");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddLogin();
                    break;
                case 2:
                    UpdateLogout();
                    break;
                case 3:
                    ViewLogs();
                    break;
            }

        } while (choice != 4);
    }

    static void AddLogin()
    {
        try
        {
            Console.Write("Enter Employee ID: ");
            string id = Console.ReadLine();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            string loginTime = DateTime.Now.ToString();

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{id}|{name}|{loginTime}|");
            }

            Console.WriteLine("Login recorded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void UpdateLogout()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No records found.");
                return;
            }

            Console.Write("Enter Employee ID: ");
            string empId = Console.ReadLine();

            List<string> lines = new List<string>();
            string[] records = File.ReadAllLines(filePath);

            bool found = false;

            foreach (string line in records)
            {
                string[] parts = line.Split('|');

                if (parts[0] == empId && parts[3] == "")
                {
                    parts[3] = DateTime.Now.ToString();
                    found = true;
                }

                lines.Add(string.Join("|", parts));
            }

            File.WriteAllLines(filePath, lines);

            if (found)
                Console.WriteLine("Logout time updated!");
            else
                Console.WriteLine("Employee not found or already logged out.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ViewLogs()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("No log file found.");
                return;
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string data = sr.ReadToEnd();
                Console.WriteLine("\n--- Logs ---");
                Console.WriteLine(data);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}