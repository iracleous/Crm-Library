using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//
/*
 * 
 
//Product
//	Id, Name, Price, {Carts}
	
//Customer
//	Id, Name, Email, {Carts}

//Cart
//	Id, Date, |Customer|, {Product}, |Payment|
	
//Payment
//	Id, Date, <|Cart|>




 * 
 */





namespace SqlAzureConnect.Models
{
    public class Cart
    {
        //Cart
        //	Id, Date, |Customer|, {Product}, |Payment|

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual IEnumerable<Product>  Products { get; set; }=new List<Product>();
        public virtual Payment? Payment { get; set; }


    }
}
