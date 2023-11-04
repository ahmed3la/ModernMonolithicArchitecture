using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DTOs
{
    public class CartDto
    {
        public Guid Id { get; set; }
        public List<ShoppingCartItemDto> ShoppingCartItems { get; set; }
    }
}
