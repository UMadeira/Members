﻿namespace Members.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IFactory Factory { get; }

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : Item;

        void Begin();
        void Commit();
        void Rollback();

        void SaveChanges();
    }
}
