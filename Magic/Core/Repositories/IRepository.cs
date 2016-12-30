﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Magic.Core.Repositories
{
    public interface IRepository<TEntity, IdEntity> where TEntity : class
    {
        TEntity Get(IdEntity id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities); 
    }
}