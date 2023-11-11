using System;
using System.Collections.Generic;
using ShoppingCart.CartEntities;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ShoppingCart.IRepository
{
    public interface IShoppingCartRepository : IRepository<Cart, Guid>
    {
        Task<Cart?> GetByOwnerAsync(Guid ownerId);
        Task<Cart> GetAsync(Guid id);
    }
}
