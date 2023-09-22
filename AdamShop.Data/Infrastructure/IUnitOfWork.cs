namespace AdamShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}