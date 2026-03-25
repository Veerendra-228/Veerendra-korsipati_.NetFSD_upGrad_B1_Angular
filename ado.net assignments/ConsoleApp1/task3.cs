using System;
using System.Data;
using Microsoft.Data.SqlClient;

class task3
{
    static string connectionString = "Data Source=LAPTOP-D08GSENH\\SQLEXPRESS01;Initial Catalog=students;Integrated Security=True;Trust Server Certificate=True;";

    static void Main()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products", con);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Products");
            DataTable table = ds.Tables["Products"];

            // Display Data
            Console.WriteLine("--- Products ---");
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"{row["ProductId"]} {row["ProductName"]} {row["Price"]} {row["Stock"]}");
            }

            // Add Product
            DataRow newRow = table.NewRow();
            newRow["ProductName"] = "Mobile";
            newRow["Price"] = 20000;
            newRow["Stock"] = 5;
            table.Rows.Add(newRow);

            // Update Product
            if (table.Rows.Count > 0)
                table.Rows[0]["Price"] = 18000;

            // Delete Product
            if (table.Rows.Count > 1)
                table.Rows[1].Delete();

            // Save changes
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Products");

            Console.WriteLine("Changes Saved to Database");
        }
    }
}
