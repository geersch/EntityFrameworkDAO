namespace Contracts
{
    public interface IDao<TEntity>
    {
        TEntity Save(TEntity entity);
        void Delete(TEntity entity);
        void SaveChanges();
    }
}
