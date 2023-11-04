using ShoppingCart.CartEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.IRepository
{
    public interface IShoppingCartItemRepository
    {
        Task<List<ShoppingCartItem>> GetItemsByCartIdAsync(Guid cartId);

    }
}
