﻿using Microsoft.Extensions.Caching.Distributed;
using SharedCaching.Contracts;
using SharedCaching.Contracts.CacheDTOs;
using SharedCaching.ICachingProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<ProductCacheEvent> GetAsync()
        {
            return await _cache.GetOrAddAsync(
                CacheKey.ProductKey.ToString()
                , async () => await GetBookFromDatabaseAsync(),
                () => new DistributedCacheEntryOptions()
            );
        }

        private Task<ProductCacheEvent> GetBookFromDatabaseAsync()
        {
            var data = new ProductCacheEvent { Name = "", Price = 10,Id=Guid.NewGuid() };

            return Task.FromResult( data );
        }

    }

    public class BookCacheItem
    {
        public string Name { get; set; } = "";

        public float Price { get; set; }
    }
}
