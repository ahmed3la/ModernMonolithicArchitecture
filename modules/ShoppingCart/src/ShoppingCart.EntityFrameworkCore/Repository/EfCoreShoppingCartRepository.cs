using Microsoft.EntityFrameworkCore;
using ShoppingCart.CartEntities;
using ShoppingCart.EntityFrameworkCore;
using ShoppingCart.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Users;

namespace ShoppingCart.Repository
{
    public class ShoppingCartRepository 
        : EfCoreRepository<ShoppingCartDbContext, Cart, Guid>
        , IShoppingCartRepository
    {
        private readonly IDbContextProvider<ShoppingCartDbContext> _dbContextProvider;
        //private readonly ICurrentUser _currentUser;

        public ShoppingCartRepository(IDbContextProvider<ShoppingCartDbContext> dbContextProvider, ICurrentUser currentUser) : base(
            dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
            //_currentUser = currentUser;
        }

        public virtual async Task<Cart?> GetByOwnerAsync(Guid ownerId)
        {
            var dbContext = await _dbContextProvider.GetDbContextAsync();
            var cart = await dbContext.Carts
                .FirstOrDefaultAsync(a => a.OwnerId == ownerId);

            return cart;
        }

        public virtual async Task<Cart> GetAsync(Guid id)
        {
            var dbContext = await _dbContextProvider.GetDbContextAsync();
            var cart = await dbContext.Carts
                .FirstOrDefaultAsync(a => a.Id == id);

            return cart;
        }




    }
}
