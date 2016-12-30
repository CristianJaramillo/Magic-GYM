using Magic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Magic.Persistence.Repositories
{
    public abstract class Repository<TEntity, IdEntity> : IRepository<TEntity, IdEntity> where TEntity : class
    {
        protected readonly DbContext Context;

        public Repository(DbContext Context)
        {
            this.Context = Context;
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {

            return Context.Set<TEntity>().ToListAsync().Result;
        }

        public TEntity Get(IdEntity id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToListAsync().Result;
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

    }
}
