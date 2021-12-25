
using AbrstractFactory.AbstractFactory;
using AbrstractFactory.AbstractProduct;
using AbrstractFactory.ConcreteProduct;
using System;

namespace AbrstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Lets create sql Connection");
            string strConnectionString = "Data Source=(local);Initial Catalog=Northwind;"
                + "Integrated Security=SSPI";
            string strsqlCommand = "SELECT OrderID, CustomerID FROM dbo.Orders;";
            DbConnectionS connection = CreateConnection(strConnectionString);
            connection.Open();           
            // Check for valid DbConnection.
            if (connection != null)
            {
                using (connection)
                {
                    try
                    {
                        // Create the command.
                        DbCommandS command = connection.CreateCommand();
                        command.CommandText = strsqlCommand;
                       

                        // Open the connection.
                        connection.Open();

                        // Retrieve the data.
                         command.ExecuteNonQuery();
                        
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception.Message: {0}", ex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("Failed: DbConnection is null.");
            }
            Console.ReadLine();


        }


        public static DbConnectionS CreateConnection(string _Connection)
        {
            DbConnectionS con = null;
            if (con == null)
            {
                try
                {
                    DbProviderFactoriesS.RegisterFactory("System.Data.SqlClientS", ConcreteFactory.SqlClientFactoryS.Instance);
                    DbProviderFactoryS DP = DbProviderFactoriesS.GetFactory("System.Data.SqlClientS");

                    con = DP.CreateConnection();
                    con.ConnectionString = _Connection;
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
            }
            return con;
        }
    }
}
