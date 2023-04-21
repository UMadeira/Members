using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using Members.Core.Repositories;

namespace Members.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork( MembersContext context, IFactory factory ) 
        { 
            Context = context;
            Factory = factory;
        }

        public IFactory Factory { get; }

        private DbContext Context { get; }

        private IDbContextTransaction? Transaction { get; set; }

        public void Begin()
        {
            Transaction = Context.Database.BeginTransaction();
        }

        public void Commit()
        {
            Transaction.Commit();
            Transaction = null;
        }

        public void Rollback()
        {
            Transaction.Rollback();
            Transaction = null;
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        private IDictionary<Type, dynamic> Repositories { get; } = new Dictionary<Type, dynamic>();

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Item
        {
            if (Repositories.ContainsKey(typeof(TEntity)))
                return Repositories[typeof(TEntity)] as IRepository<TEntity>;

            var repository = new Repository<TEntity>(this, Context);
            Repositories.Add(typeof(TEntity), repository);

            return repository;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
