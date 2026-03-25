using System;
using Microsoft.Data.SqlClient;

class Program
{
    // Connection String (Update this)
    static string connectionString = "Data Source=LAPTOP-D08GSENH\\SQLEXPRESS01;Initial Catalog=students;Integrated Security=True;Trust Server Certificate=True";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student Grade");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InsertStudent();
                    break;
                case 2:
                    GetStudents();
                    break;
                case 3:
                    UpdateStudent();
                    break;
                case 4:
                    DeleteStudent();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }

    // ➤ 1. INSERT
    static void InsertStudent()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Students (Name, Age, Grade) VALUES (@Name, @Age, @Grade)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Grade", grade);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("✅ Student Added Successfully");
        }
    }

    // ➤ 2. READ
    static void GetStudents()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\n--- Student List ---");

            while (reader.Read())
            {
                Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, Grade: {reader["Grade"]}");
            }
        }
    }

    // ➤ 3. UPDATE
    static void UpdateStudent()
    {
        Console.Write("Enter Student Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter New Grade: ");
        string grade = Console.ReadLine();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "UPDATE Students SET Grade=@Grade WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Grade", grade);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("✅ Updated Successfully");
            else
                Console.WriteLine("❌ Student Not Found");
        }
    }

    // ➤ 4. DELETE
    static void DeleteStudent()
    {
        Console.Write("Enter Student Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Students WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("✅ Deleted Successfully");
            else
                Console.WriteLine("❌ Student Not Found");
        }
    }
}