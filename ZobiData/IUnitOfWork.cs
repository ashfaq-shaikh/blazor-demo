using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zobi.Data.Repository;

namespace Zobi.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        //        IRepositoryAsync<TEntity> GetRepositoryAsync<TEntity>() where TEntity : class;
      
        int SaveChanges();
    }

    //public interface IUnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    //{
    //    TContext Context { get; }
    //}
}
