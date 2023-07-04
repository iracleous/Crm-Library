using SqlAzureConnect.DbContexts;
using SqlAzureConnect.Models;
using SqlAzureConnect.Services;

//ConnectToDb connectToDb = new ConnectToDb();
//connectToDb.DoWork();


using var crmDbContext = new CrmDbContext();
var productServices = new ProductServices(crmDbContext);

productServices.ReadProduct();

productServices.UpdateProduct();
productServices.DeleteProduct();

productServices.ReadProduct();