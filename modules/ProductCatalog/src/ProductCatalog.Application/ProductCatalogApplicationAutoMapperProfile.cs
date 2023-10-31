using AutoMapper;
using ProductCatalog.DTOs;
using ProductCatalog.ProductEntities;

namespace ProductCatalog;

public class ProductCatalogApplicationAutoMapperProfile : Profile
{
    public ProductCatalogApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Product, ProductDto>(); 


    }
}
