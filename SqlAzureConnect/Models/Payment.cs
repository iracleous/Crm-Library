using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.Models
{
    public class Payment
    {
        //Payment
        //	Id, Date, <|Cart|>
        public int Id { get; set; }
        public DateTime Date{ get; set; }
         
    }
}
