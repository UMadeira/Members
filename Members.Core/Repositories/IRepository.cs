namespace Members.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : Item
    {
        TEntity Create( params object?[]? args );

        IEnumerable<TEntity> GetAll();
        TEntity?             Get(int id);

        void Insert(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
