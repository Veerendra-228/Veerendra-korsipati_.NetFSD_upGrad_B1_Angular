using System;
using System.IO;

class MiniNotepad
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Mini Notepad ---");
            Console.WriteLine("1. Create New File");
            Console.WriteLine("2. Write to File");
            Console.WriteLine("3. Read File");
            Console.WriteLine("4. Append Text");
            Console.WriteLine("5. Delete File");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    CreateFile();
                    break;
                case 2:
                    WriteFile();
                    break;
                case 3:
                    ReadFile();
                    break;
                case 4:
                    AppendFile();
                    break;
                case 5:
                    DeleteFile();
                    break;
            }

        } while (choice != 6);
    }

    static void CreateFile()
    {
        try
        {
            Console.Write("Enter file name (without extension): ");
            string fileName = Console.ReadLine() + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                Console.WriteLine("File created successfully!");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Permission denied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void WriteFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine() + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("Enter text (type 'END' to stop):");

                while (true)
                {
                    string line = Console.ReadLine();
                    if (line.ToUpper() == "END")
                        break;

                    sw.WriteLine(line);
                }
            }

            Console.WriteLine("Data written successfully!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Permission denied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void ReadFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine() + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
                return;
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine("\n--- File Content ---");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Permission denied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void AppendFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine() + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("Enter text to append (type 'END' to stop):");

                while (true)
                {
                    string line = Console.ReadLine();
                    if (line.ToUpper() == "END")
                        break;

                    sw.WriteLine(line);
                }
            }

            Console.WriteLine("Text appended successfully!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Permission denied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void DeleteFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine() + ".txt";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("File deleted successfully!");
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Permission denied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}