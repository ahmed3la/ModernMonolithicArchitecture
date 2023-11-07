using Microsoft.Extensions.Caching.Distributed;
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

        public async Task HandleEventAsync(ProductCacheEvent eventData)
        {

            //var cacheKey = "YourUniqueCacheKey"; // Replace with your unique cache key.

            //var IsCashExist = cache.Get(cacheKey); // Cache for 30 minutes (adjust the expiration time as needed).
            //if (IsCashExist != null)
            //{
            //    await cache.SetAsync(
            //    cacheKey.ToString(), //Cache key
            //    eventData);
            //}
            //else
            //{
            //    var x = await cache.GetOrAddAsync(
            //        cacheKey.ToString(), //Cache key
            //        async () => await Task.FromResult(eventData),
            //        () => new DistributedCacheEntryOptions
            //        {
            //            AbsoluteExpiration = DateTimeOffset.Now.AddHours(1)
            //        }
            //    );
            //}

        }

    }
}
