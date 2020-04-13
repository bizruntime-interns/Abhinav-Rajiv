using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Actors;
using Microsoft.ServiceFabric.Actors.Runtime;
using Microsoft.ServiceFabric.Actors.Client;
using productActorService.Interfaces;
using contracts;

namespace productActorService
{

    [StatePersistence(StatePersistence.Persisted)]
    internal class productActorService : Actor, IproductActorService
    {
        private string productStateName = "ProductSate";

        public productActorService(ActorService actorService, ActorId actorId)
            : base(actorService, actorId)
        {
        }

        public async Task AddProductAsync(Product product, CancellationToken cancellationToken)
        {
            await this.StateManager.AddOrUpdateStateAsync(productStateName, product, (k, v) => product, cancellationToken);
            await this.StateManager.SaveStateAsync(cancellationToken);
        }

        public async Task<Product> GetProductAsync(CancellationToken cancellationToken)
        {
            Product product = await this.StateManager.GetStateAsync<Product>(productStateName, cancellationToken);
            return product;

        }


        protected override Task OnActivateAsync()
        {
            ActorEventSource.Current.ActorMessage(this, "Actor activated.");

            // The StateManager is this actor's private state store.
            // Data stored in the StateManager will be replicated for high-availability for actors that use volatile or persisted state storage.
            // Any serializable object can be saved in the StateManager.
            // For more information, see https://aka.ms/servicefabricactorsstateserialization

            return this.StateManager.TryAddStateAsync("count", 0);
        }



    }
}
