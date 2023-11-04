using System; 
using Volo.Abp.Domain.Entities;

namespace ShoppingCart.CartEntities
{
    public class ShoppingCartItem : Entity<Guid>
    {
        public Guid CartId { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public ShoppingCartItem(Guid Id, Guid cartId, Guid productId, int quantity, decimal price)
            : base(Id)
        {
            CartId = cartId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }

        // Other properties and methods related to shopping cart items.

    }
}
