using System;
using Microsoft.Data.SqlClient;

class task4
{
    static string connectionString = "Data Source=LAPTOP-D08GSENH\\SQLEXPRESS01;Initial Catalog=students;Integrated Security=True;TrustServerCertificate=True;";

    static void Main()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            SqlTransaction transaction = con.BeginTransaction();

            try
            {
                // Insert Order
                SqlCommand orderCmd = new SqlCommand(
                    "INSERT INTO Orders (CustomerName, TotalAmount) OUTPUT INSERTED.OrderId VALUES (@Name, @Amount)",
                    con, transaction);

                orderCmd.Parameters.AddWithValue("@Name", "Rahul");
                orderCmd.Parameters.AddWithValue("@Amount", 2000);

                int orderId = (int)orderCmd.ExecuteScalar();

                // Insert OrderItems
                SqlCommand itemCmd = new SqlCommand(
                    "INSERT INTO OrderItems (OrderId, ProductName, Quantity) VALUES (@OrderId, @Product, @Qty)",
                    con, transaction);

                itemCmd.Parameters.AddWithValue("@OrderId", orderId);
                itemCmd.Parameters.AddWithValue("@Product", "Mouse");
                itemCmd.Parameters.AddWithValue("@Qty", 2);

                itemCmd.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine(" Transaction Successful");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("❌ Transaction Failed");
                Console.WriteLine(ex.Message);
            }
        }
    }
}