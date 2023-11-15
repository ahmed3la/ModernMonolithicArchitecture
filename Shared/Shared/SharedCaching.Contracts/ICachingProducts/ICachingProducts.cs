using SharedCaching.Contracts.CacheDTOs;

namespace SharedCaching.ICachingProducts
{
    public interface ICachingProduct
    { 
        Task<ProductCacheEvent> GetAsync(Guid id);
    }
}
