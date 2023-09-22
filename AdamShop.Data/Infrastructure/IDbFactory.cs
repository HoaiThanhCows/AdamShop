using System;

namespace AdamShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        AdamShopDbContext Init();
    }
}