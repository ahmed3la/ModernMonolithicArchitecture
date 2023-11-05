using SharedCaching.Contracts.CacheDTOs;
using SharedCaching.ICachingProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Caching;

namespace SharedCaching.CachingProducts
{
    public class CachingProduct : ICachingProduct
    {
        private readonly IDistributedCache<ProductCache> _cache;

        public CachingProduct(IDistributedCache<ProductCache> cache)
        {
            _cache = cache;
        }


        public string GetProductName()
        {
            return "Test";
        }
    }
}
