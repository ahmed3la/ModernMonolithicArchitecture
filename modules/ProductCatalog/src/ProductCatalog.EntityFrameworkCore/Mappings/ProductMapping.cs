using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductCatalog.ProductEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ProductCatalog.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", ProductCatalogDbProperties.DbSchema);
            builder.Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Description).HasMaxLength(100);
            builder.ConfigureByConvention();
        }
    }
}
