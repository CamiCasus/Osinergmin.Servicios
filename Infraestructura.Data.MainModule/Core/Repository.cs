using Infraestructura.Data.MainModule.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infraestructura.Data.MainModule.Core
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId>, IDisposable
        where TEntity : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        protected DbContext Context
        {
            get { return _dbContext; }
        }

        protected DbSet<TEntity> DbSet
        {
            get { return _dbSet; }
        }

        public virtual TEntity Add(TEntity entity)
        {
            return DbSet.Add(entity).Entity;
        }

        public virtual void Delete(TEntity entity)
        {
            DbSet.Attach(entity);

            var entry = Context.Entry(entity);
            entry.State = EntityState.Deleted;
        }

        public TEntity Get(TId id)
        {
            return DbSet.Find(id);
        }

        public virtual void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            var entry = Context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public virtual IQueryable<TEntity> All(bool @readonly = true)
        {
            return @readonly
                ? DbSet.AsNoTracking()
                : DbSet;
        }

        public virtual int Count(Expression<Func<TEntity, bool>> expression)
        {
            return DbSet.Where(expression).Count();
        }

        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = true)
        {
            return @readonly
                ? DbSet.Where(predicate).AsNoTracking()
                : DbSet.Where(predicate);
        }

        //public virtual PaginationResult<TEntity> FindAllPaging(PaginationParameters<TEntity> parameters, bool @readonly = true)
        //{
        //    IQueryable<TEntity> listaAPaginar = GetDataWithFilter(parameters, @readonly);
        //    return Paginar(parameters, listaAPaginar);
        //}

        //public IQueryable<TEntity> GetDataWithFilter(PaginationParameters<TEntity> parameters, bool @readonly = true)
        //{
        //    return (@readonly ? DbSet.AsNoTracking() : DbSet).Where(parameters.WhereFilter);
        //}

        //public PaginationResult<TEntity> Paginar(PaginationParameters<TEntity> parameters, IQueryable<TEntity> listaAPaginar)
        //{
        //    return Paginar<TEntity>(parameters, listaAPaginar);
        //}

        //protected PaginationResult<TNewEntity> Paginar<TNewEntity>(PaginationParameters<TNewEntity> parameters,
        //    IQueryable<TNewEntity> listaAPaginar) where TNewEntity : class
        //{
        //    listaAPaginar = (parameters.OrderType == TipoOrdenamiento.Ascending)
        //       ? Queryable.OrderBy(listaAPaginar, (dynamic)parameters.ColumnOrder)
        //       : Queryable.OrderByDescending(listaAPaginar, (dynamic)parameters.ColumnOrder);

        //    return new PaginationResult<TNewEntity>
        //    {
        //        Count = listaAPaginar.Count(),
        //        Entities = listaAPaginar.Skip(parameters.Start).Take(parameters.AmountRows)
        //    };
        //}

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            if (Context == null) return;
            Context.Dispose();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        #endregion
    }
}
