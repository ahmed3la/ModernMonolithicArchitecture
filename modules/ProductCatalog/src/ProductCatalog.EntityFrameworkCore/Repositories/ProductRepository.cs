using Microsoft.EntityFrameworkCore;
using ProductCatalog.EntityFrameworkCore;
using ProductCatalog.IRepository;
using ProductCatalog.ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ProductCatalog.Repositories
{

    public class ProductRepository : EfCoreRepository<ProductCatalogDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<ProductCatalogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<Product>> GetListAsync()
        {
            var dbContext = await GetDbContextAsync();

            var result = await dbContext.Products.ToListAsync();

            return result;

        }


    }
}
