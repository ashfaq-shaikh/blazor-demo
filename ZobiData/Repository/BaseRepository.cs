using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zobi.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected DbContext _dbContext;
        protected DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));
            _dbSet = _dbContext.Set<T>();
        }

        /// <summary>
        /// Return DBContext. This method will be used to check the DBCOntext object is exists or not.
        /// </summary>
        /// <returns>DbContext of ZobiDBContext</returns>
        public DbContext GetContext()
        {
            return _dbContext;
        }

        /// <summary>
        /// Set new object of ZobiDBContext. DBContext object returns nothing for connection string. 
        /// Connectionstring is blank when call DBContext object without HTTP call.
        /// </summary>
        /// <param name="context">DbContext of ZobiDBContext</param>
        public void SetContext(DbContext context)
        {
            _dbContext = context ?? throw new ArgumentException(nameof(context));
            _dbSet = _dbContext.Set<T>();
        }

        public virtual IQueryable<T> Query(string sql, params object[] parameters)
        {
            return _dbSet.FromSqlRaw(sql, parameters);
        }

        /// <summary>
        /// Execute procedure with params and return data by fullfill the object of IData by help of reflection.
        /// </summary>
        /// <typeparam name="TData">Return Model</typeparam>
        /// <param name="procedureName">Procedure name</param>
        /// <param name="parameters">array of SqlParameter(SqlParameter[])</param>
        /// <returns></returns>
        public async Task<List<TData>> ExecProcedure<TData>(string procedureName, params object[] parameters)
        {
            using (var cnn = _dbContext.Database.GetDbConnection())
            {
                var cmm = cnn.CreateCommand();
                cmm.CommandType = System.Data.CommandType.StoredProcedure;
                cmm.CommandText = procedureName;
                cmm.Parameters.AddRange(parameters);
                cmm.Connection = cnn;
                cnn.Open();

                try
                {
                    using (var reader = cmm.ExecuteReader())
                    {
                        return reader.MapToList<TData>();
                    }
                }
                catch (Exception ex)
                {
                    //Log errors in logger.
                    throw ex;

                }
                finally
                {
                    cnn.Close();
                }
            }
        }

        public T Search(params object[] keyValues) => _dbSet.Find(keyValues);


        public T Single(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking) query = query.AsNoTracking();

            if (include != null) query = include(query);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return orderBy(query).FirstOrDefault();
            return query.FirstOrDefault();
        }


        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Add(params T[] entities)
        {
            _dbSet.AddRange(entities);
        }


        public void Add(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }


        public void Delete(T entity)
        {
            var existing = _dbSet.Find(entity);
            if (existing != null) _dbSet.Remove(existing);
        }


        public void Delete(object id)
        {
            var typeInfo = typeof(T).GetTypeInfo();
            var key = _dbContext.Model.FindEntityType(typeInfo).FindPrimaryKey().Properties.FirstOrDefault();
            var property = typeInfo.GetProperty(key?.Name);
            if (property != null)
            {
                var entity = Activator.CreateInstance<T>();
                property.SetValue(entity, id);
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            else
            {
                var entity = _dbSet.Find(id);
                if (entity != null) Delete(entity);
            }
        }

        public void Delete(params T[] entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Delete(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }


        public List<T> Get()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsEnumerable();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Update(params T[] entities)
        {
            _dbSet.UpdateRange(entities);
        }


        public void Update(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

    }
}
