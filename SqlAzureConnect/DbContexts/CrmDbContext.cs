using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using SqlAzureConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.DbContexts
{
    public class CrmDbContext : DbContext
    {

        //     private readonly string connectionString = "Data Source=(local);Initial Catalog=Crm-2023;" +
        //        "User Id=sa; Password=passw0rd;TrustServerCertificate=True;";

             private readonly string connectionString = "Data Source=(local);Initial Catalog=Crm-2023;" +
                " Integrated security=true;TrustServerCertificate=True;";


        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Payment> Payments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
