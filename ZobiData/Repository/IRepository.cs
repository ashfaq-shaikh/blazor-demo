using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Zobi.Data.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {

        //IQueryable<T> Query<T>(string sql, params object[] parameters);
        IQueryable<T> Query(string sql, params object[] parameters);
        DbContext GetContext();
        void SetContext(DbContext context);
        Task<List<TData>> ExecProcedure<TData>(string procedureName, params object[] parameters);

        T Search(params object[] keyValues);

        T Single(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool disableTracking = true);


        void Add(T entity);
        void Add(params T[] entities);
        void Add(IEnumerable<T> entities);


        void Delete(T entity);
        void Delete(object id);
        void Delete(params T[] entities);
        void Delete(IEnumerable<T> entities);

        List<T> Get();       
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        

        void Update(T entity);
        void Update(params T[] entities);
        void Update(IEnumerable<T> entities);
    }
}
