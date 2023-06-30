using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.Models
{

    // Product 
	//Id, Name, Price, {Carts}
 

public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<Cart> Carts { get; set; } = new List<Cart>();

    }
}
