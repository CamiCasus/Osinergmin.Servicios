using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infraestructura.Data.MainModule.Core.Interfaces
{
    public interface IRepository<TEntity, in TId> where TEntity : class
    {
        Task Add(TEntity entity);
        Task AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> Get(TId id, bool @readonly = true);
        int Count(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> All(bool @readonly = true);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate, bool @readonly = true);

        //PaginationResult<TEntity> FindAllPaging(PaginationParameters<TEntity> parameters, bool @readonly = true);
        //IQueryable<TEntity> GetDataWithFilter(PaginationParameters<TEntity> parameters, bool @readonly = true);
        //PaginationResult<TEntity> Paginar(PaginationParameters<TEntity> parameters,
        //    IQueryable<TEntity> listaAPaginar);
    }
}
