using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace communication
{
   public interface IstatefullInt:IService
    {
        Task<string> getservicedetails();
        Task<Product> GetproductByid(int id);
        Task Addproduct(Product product);

    }
}
