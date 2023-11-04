﻿using Volo.Abp.Reflection;

namespace ShoppingCart.Permissions;

public class ShoppingCartPermissions
{
    public const string GroupName = "ShoppingCart";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ShoppingCartPermissions));
    }
}
