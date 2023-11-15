using SharedCaching.Contracts;
using SharedCaching.Contracts.CacheDTOs;
using SharedCaching.ICachingProducts;
using Volo.Abp.Caching;

namespace SharedCaching.CachingProducts
{
    public class CachingProduct : ICachingProduct
    {
        private readonly IDistributedCache<ProductCacheEvent> _cache;

        public CachingProduct(IDistributedCache<ProductCacheEvent> cache)
        {
            _cache = cache;
        }

        public async Task<ProductCacheEvent> GetAsync(Guid id)
        {
            var product = await _cache.GetAsync(id.ToString()) 
                ?? throw new Exception("The product not exist in the cache");

            return product;
        }

      
    }
 
}
