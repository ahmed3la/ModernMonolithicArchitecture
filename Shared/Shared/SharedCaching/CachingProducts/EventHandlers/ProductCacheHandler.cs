using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Extensions.Caching.Distributed;
using SharedCaching.Contracts;
using SharedCaching.Contracts.CacheDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using Volo.Abp.Threading;

namespace SharedCaching.CachingProducts.EventHandlers
{
    public class ProductCacheHandler
        : ILocalEventHandler<ProductCacheEvent>,
          ITransientDependency
    {
        private readonly IDistributedCache<ProductCacheEvent> cache;

        public ProductCacheHandler(IDistributedCache<ProductCacheEvent> cache)
        {
            this.cache = cache;
        }

        public IDistributedCache<ProductCacheEvent, ProductCacheEvent> Cache { get; }

         
        public async Task HandleEventAsync(ProductCacheEvent eventData)
        {  
            await cache.SetAsync(eventData.ToString(), eventData); 
        }

    }
}
