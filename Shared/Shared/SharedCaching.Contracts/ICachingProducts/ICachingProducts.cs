using SharedCaching.Contracts.CacheDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCaching.ICachingProducts
{
    public interface ICachingProduct
    {
        Task<ProductCacheEvent> GetAsync(Guid bookId);
    }
}
