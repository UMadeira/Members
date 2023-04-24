using Members.Core.Repositories;

namespace Members.Data
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        IRepositoryAsync<TEntity>? GetRepositoryAsync<TEntity>() where TEntity : Item;

        Task SaveChangesAsync();
    }
}
