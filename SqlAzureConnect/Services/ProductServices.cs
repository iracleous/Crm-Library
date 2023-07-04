using SqlAzureConnect.DbContexts;
using SqlAzureConnect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.Services
{
    public class ProductServices : IProductServices
    {

        private readonly CrmDbContext _crmDbContext;

        public ProductServices(CrmDbContext crmDbContext)
        {
                _crmDbContext = crmDbContext;
        }

        public void CreateProduct()
        {
            //create
            var product = new Product { Id = 0, Name = "chips", Price = 1.20m };
            Console.WriteLine($"Id = {product.Id} Name= {product.Name}");
            _crmDbContext.Products.Add(product);
            _crmDbContext.SaveChanges();
            Console.WriteLine($"Id = {product.Id} Name= {product.Name}");

        }

        public void DeleteProduct()
        {
          int productId = 1;
          var product =  _crmDbContext
                .Products
                .Where(x => x.Id == productId)
                .FirstOrDefault();
            if ( product != null ) 
            {
                _crmDbContext
                    .Products
                    .Remove(product);  
                _crmDbContext.SaveChanges();
            }
        }

        public void ReadProduct()
        {
            List<Product> products = _crmDbContext.Products.ToList();
            products.ForEach( product =>
            { Console.WriteLine($"product.id = {product.Id} product.Nam = {product.Name}") ; });
        }

        public void UpdateProduct()
        {
            int productId = 3;
            decimal newPrice = 1.80m;
            var product = _crmDbContext
              .Products
              .Where(x => x.Id == productId)
              .FirstOrDefault();
            if (product != null)
            {
                product.Price = newPrice;
                _crmDbContext.SaveChanges();
            }
        }
    }
}
