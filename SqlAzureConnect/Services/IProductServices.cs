using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAzureConnect.Services
{
    public interface IProductServices
    {
        public void CreateProduct();
        public void ReadProduct();
        public void UpdateProduct();
        public void DeleteProduct();
    }
}
