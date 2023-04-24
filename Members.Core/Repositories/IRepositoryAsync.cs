using Members.Core.Repositories;

namespace Members.Data
{
    public interface IRepositoryAsync<TEntity> : IRepository<TEntity> where TEntity : Item
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetAsync(int id);

        Task InsertAsync(TEntity item);
    }
}
