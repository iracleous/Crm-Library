using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.Models
{

    //Customer
    //	Id, Name, Email, {Carts}

    public class Customer
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public virtual IEnumerable<Cart> Carts { get; set; } = new List<Cart>();  
    }
}
