using AutoMapper;
using ShoppingCart.CartEntities;
using ShoppingCart.DTOs;

namespace ShoppingCart;

public class ShoppingCartApplicationAutoMapperProfile : Profile
{
    public ShoppingCartApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<ShoppingCartItem, ShoppingCartItemDto>();
        CreateMap<Cart, CartDto>();
    }
}
