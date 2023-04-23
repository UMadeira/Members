namespace Members.Core.Repositories
{
    public interface IRepositoryAsync<TEntity> where TEntity : Item
    {
        TEntity Create( params object?[]? args );

        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?>             GetAsync(int id);

        Task InsertAsync(TEntity item);
        Task UpdateAsync(TEntity item);
        Task DeleteAsync(TEntity item);
    }
}
