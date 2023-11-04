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
    public class EfCoreShoppingCartItemRepository : EfCoreRepository<ShoppingCartDbContext, Cart, Guid>
        , IShoppingCartItemRepository,
    ITransientDependency
    {
        private readonly IDbContextProvider<ShoppingCartDbContext> _dbContextProvider;
        private readonly ICurrentUser _currentUser;

        public EfCoreShoppingCartItemRepository(IDbContextProvider<ShoppingCartDbContext> dbContextProvider, ICurrentUser currentUser) : base(
            dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
            _currentUser = currentUser;
        }

          
        public virtual async Task<List<ShoppingCartItem>> GetItemsByCartIdAsync(Guid cartId)
        {
            var dbContext = await _dbContextProvider.GetDbContextAsync();
            var shoppingCartItems = await dbContext.ShoppingCartItems
                .Where(a => a.CartId == cartId).ToListAsync();

            return shoppingCartItems;
        }
    }
}
