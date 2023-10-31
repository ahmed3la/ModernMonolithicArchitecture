using ProductCatalog.ProductEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ProductCatalog.IRepository
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
        public interface IProductRepository : IRepository<Product, Guid>
        {
            Task<List<Product>> GetListAsync();
        }

         
    }
}
