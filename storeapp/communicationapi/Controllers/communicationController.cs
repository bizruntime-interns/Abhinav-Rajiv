using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using communication;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Microsoft.ServiceFabric.Services.Client;

namespace communicationapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class communicationController : ControllerBase
    {

        [HttpGet]
        [Route("stateless")]
        public async Task<string> Statelessget()
        {
            var stateless = ServiceProxy.Create<IstatelessInt>(new Uri("fabric:/storeapp/customeranal"));
            var servicename = await stateless.getservicedetails();
            return servicename;
        }

        [HttpGet]
        [Route("stateful")]
        public async Task<string> statefulget([FromQuery] int reg)
        {

            long productno = reg % 3;

            var stateful = ServiceProxy.Create<IstatefullInt>(new Uri("fabric:/storeapp/Productcat"), new Microsoft.ServiceFabric.Services.Client.ServicePartitionKey(productno));
            var servicename = await stateful.getservicedetails();
            return servicename;
        }

        [HttpGet]
        [Route("getproduct")]
        public async Task<Product> getproduct([FromQuery] int productid)
        {
            long partno = productid % 3;
            var statefullproxy = ServiceProxy.Create<IstatefullInt>(new Uri("fabric:/storeapp/Productcat"), new ServicePartitionKey(partno));
            var product = await statefullproxy.GetproductByid(productid);
            return product;
        }

        [HttpPost]
        [Route("addproduct")]
        public async Task Addproduct([FromQuery] Product product)
        {
            var partno = product.id % 3;
            var statefullproxy = ServiceProxy.Create<IstatefullInt>(new Uri("fabric:/storeapp/Productcat"), new ServicePartitionKey(partno));
            await statefullproxy.Addproduct(product);

        }
    }
}
