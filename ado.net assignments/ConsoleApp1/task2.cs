using System;
using System.Data;
using Microsoft.Data.SqlClient;

class task2
{
    static string connectionString = "Data Source=LAPTOP-D08GSENH\\SQLEXPRESS01;Initial Catalog=students;Integrated Security=True;Trust Server Certificate=True;";

    static void Main()
    {
        InsertEmployee();
        GetEmployeesByDepartment("HR");
        UpdateSalary(1, 60000);
        DeleteEmployee(1);
    }

    // 1. Insert using Stored Procedure
    static void InsertEmployee()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", "Alice");
            cmd.Parameters.AddWithValue("@Salary", 50000);
            cmd.Parameters.AddWithValue("@Department", "HR");

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Inserted");
        }
    }

    // 2. Fetch by Department
    static void GetEmployeesByDepartment(string dept)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Employees WHERE Department=@Dept";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Dept", dept);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("\nEmployees in " + dept);
            while (reader.Read())
            {
                Console.WriteLine($"{reader["EmpId"]} {reader["Name"]} {reader["Salary"]}");
            }
        }
    }

    // 3. Update Salary (Stored Procedure)
    static void UpdateSalary(int id, decimal salary)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("UpdateSalary", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpId", id);
            cmd.Parameters.AddWithValue("@Salary", salary);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Salary Updated");
        }
    }

    // 4. Delete Employee
    static void DeleteEmployee(int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Employees WHERE EmpId=@Id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Deleted");
        }
    }
}
