namespace Members.Core.Repositories
{
    public interface IUnitOfWorkAsync : IDisposable
    {
        IFactory Factory { get; }

        IRepositoryAsync<TEntity> GetRepositoryAsyn<TEntity>() where TEntity : Item;

        void Begin();
        void Commit();
        void Rollback();

        void SaveChanges();
    }
}
