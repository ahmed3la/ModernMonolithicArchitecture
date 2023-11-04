﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ShoppingCart.EntityFrameworkCore;

[ConnectionStringName(ShoppingCartDbProperties.ConnectionStringName)]
public interface IShoppingCartDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
