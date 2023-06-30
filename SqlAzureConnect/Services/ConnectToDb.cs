using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.Services
{
    public class ConnectToDb
    {
        public void DoWork()
        {
            Console.WriteLine("Hello, World!");

            //string connectionString = "Server=tcp:databaseserverregen.database.windows.net,1433;Initial Catalog=clouddb;Persist Security Info=False;User ID=dimitris;Password=d1m1tr1s!@#$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            try
            {
                string connectionString = "Data Source=(local);Initial Catalog=AdventureWorks2019;User Id=sa; Password=passw0rd;TrustServerCertificate=True; ";
                //string connectionString = "Server=(local);Initial Catalog=AdventureWorks2019;Persist Security Info=True;User ID=sa;" +
                //    "Password=passw0rd; TrustServerCertificate=True; ";

                using var connection = new SqlConnection(connectionString);

                string query = "select top 20 [FirstName], [LastName], [EmailPromotion] from [Person].[Person]";

                using var command = new SqlCommand(query, connection);
                connection.Open();
                using var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"FirstName {reader.GetString(0)} LastName {reader.GetString(1)} " +
                        $"EmailPromotion {reader.GetInt32(2)}");
                }

                Console.WriteLine("Terminated");
            }
            catch (Exception e)
            {
                Console.WriteLine("error " + e.Message);
            }
        }
    }
}
