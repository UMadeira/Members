using Members.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Members.Data
{
    public class UnitOfWorkAsync : UnitOfWork, IUnitOfWorkAsync
    {
        public UnitOfWorkAsync(MembersContext context, IFactory factory)
            : base(context, factory)
        {
        }

        public IRepositoryAsync<TEntity>? GetRepositoryAsync<TEntity>() where TEntity : Item
        {
            return GetRepository<TEntity>() as IRepositoryAsync<TEntity>;
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        protected override IRepository<TEntity>? CreateRepository<TEntity>(IUnitOfWork unitOfWork, DbContext context)
        {
            return new RepositoryAsync<TEntity>(this, Context);
        }

    }
}
