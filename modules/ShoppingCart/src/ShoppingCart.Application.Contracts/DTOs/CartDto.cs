using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DTOs
{
    public class CartDto
    {
        public CartDto()
        {
            ShoppingCartItems = new List<ShoppingCartItemDto>();
        }
        public Guid Id { get; set; }
        public Guid OwnerId { get; set; }
        public List<ShoppingCartItemDto> ShoppingCartItems { get; set; }
    }
}
