using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Client;
using productActorService.Interfaces;


namespace productApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //fabric:/productActorApp/IproductActorServiceActorService
        // GET api/values
        [HttpGet]
        [Route("getproducts")]
        public async Task<Product> GetProducts([FromQuery] int id)
        {
            ActorId actorid = new ActorId(id);
            var proxy = ActorProxy.Create<IproductActorService>(actorid, new Uri("fabric:/productActorApp/IproductActorServiceActorService"));
            Product product = await proxy.GetProductAsync(new System.Threading.CancellationToken());
            return product;
        }

        [HttpPost]
        [Route("addproducts")]
        public async Task addProducts([FromBody] Product product)
        {
            ActorId actorid = new ActorId(product.id);
            var proxy = ActorProxy.Create<IproductActorService>(actorid, new Uri("fabric:/productActorApp/IproductActorServiceActorService"));
            await proxy.AddProductAsync(product, new System.Threading.CancellationToken());
           
        }



        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
