using System;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();//Init db context
    }
}