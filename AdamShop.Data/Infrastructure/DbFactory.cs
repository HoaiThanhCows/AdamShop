namespace AdamShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private AdamShopDbContext dbContext;

        public AdamShopDbContext Init()
        {
            return dbContext ?? (dbContext = new AdamShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}