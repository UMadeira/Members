using Microsoft.EntityFrameworkCore;
using Members.Core.Repositories;

namespace Members.Data
{
    public class RepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : Item
    {
        public RepositoryAsync( IUnitOfWorkAsync unitOfWork, DbContext context )
        {
            UnitOfWork = unitOfWork;
            Context    = context;
        }

        private IUnitOfWorkAsync UnitOfWork { get; set; }

        private DbContext Context { get; set; }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity?> Get( int id ) 
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync( x => x.Id == id );
        }

        public TEntity Create( params object?[]? args )
        {
            return UnitOfWork.Factory.Create<TEntity>(args);
        }

        public async Task InsertAsync(TEntity item)
        {
            return await Context.Set<TEntity>().AddAsync(item);
        }

        public async Task UpdateAsync(TEntity item)
        {
            Context.Entry(item).State = EntityState.Modified;
        }

        public async Task DeleteAsync(TEntity item)
        {
            await Context.A(item);
        }

    }
}
