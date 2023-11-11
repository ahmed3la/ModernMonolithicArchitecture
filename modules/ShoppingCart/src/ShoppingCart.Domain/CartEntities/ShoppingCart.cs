using ShoppingCart.CartEntities;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace ShoppingCart.CartEntities
{
    public class Cart : AggregateRoot<Guid>
    {
        public Guid OwnerId { get; private set; }

        private readonly List<ShoppingCartItem> _items;
        public IReadOnlyList<ShoppingCartItem> Items => _items;

        public Cart(Guid id, Guid ownerId)
            : base(id)
        {
            OwnerId = ownerId;
            _items = new List<ShoppingCartItem>();
        }

        public void AddItem(Guid itemId, Guid cartId, Guid productId, int quantity, decimal price)
        {
            // Implement logic to add items to the shopping cart.
            // Ensure business rules are enforced, e.g., checking product availability.
            _items.Add(new ShoppingCartItem(itemId, cartId, productId, quantity, price));
        }
        public Cart AddCard(Guid cartId)
        {
            // Implement logic to add items to the shopping cart.
            // Ensure business rules are enforced, e.g., checking product availability.
            Id = cartId;
            
            return this;
        }


    }
}
