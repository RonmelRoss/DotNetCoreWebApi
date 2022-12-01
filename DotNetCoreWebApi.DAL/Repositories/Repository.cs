using DotNetCoreWebApi.DAL.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DotNetCoreWebApi.DAL.Repositories;

public class Repository<TContext> : IRepository
    where TContext : DbContext
{
    protected TContext context;
    public Repository(TContext context)
    {
        this.context = context;
    }

    public void Delete<TEntity>(TEntity entity)
        where TEntity : class
    {
        context.Set<TEntity>().Remove(entity);
    }

    public IQueryable<TEntity> GetAll<TEntity>()
        where TEntity : class
    {
        return context.Set<TEntity>();
    }

    public TEntity GetById<TEntity>(object id)
        where TEntity : class
    {
        return context.Set<TEntity>().Find(id);
    }

    public void Insert<TEntity>(TEntity entity)
        where TEntity : class
    {
        context.Set<TEntity>().Add(entity);
    }

    public IQueryable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter)
        where TEntity : class
    {
        return context.Set<TEntity>().Where(filter);
    }

    public void Update<TEntity>(TEntity entity)
        where TEntity : class
    {
        context.Set<TEntity>().Attach(entity);
        context.Entry(entity).State = EntityState.Modified;
    }

    public virtual void Save()
    {
        try
        {
            context.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
    }
}
