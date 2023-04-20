﻿using Auth.Data.Classes;

namespace Members.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : Item
    {

        IEnumerable<TEntity> GetAll();

        TEntity Create(params object?[]? args);

        void Insert(TEntity item);
        void Update(TEntity item);
        void Delete(TEntity item);
    }
}
