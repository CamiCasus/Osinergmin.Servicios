using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infraestructura.Data.MainModule.Core.Interfaces
{
    public interface IRepository<TEntity, in TId> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(TId id);
        int Count(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> All(bool @readonly = true);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = true);

        //PaginationResult<TEntity> FindAllPaging(PaginationParameters<TEntity> parameters, bool @readonly = true);
        //IQueryable<TEntity> GetDataWithFilter(PaginationParameters<TEntity> parameters, bool @readonly = true);
        //PaginationResult<TEntity> Paginar(PaginationParameters<TEntity> parameters,
        //    IQueryable<TEntity> listaAPaginar);
    }
}
