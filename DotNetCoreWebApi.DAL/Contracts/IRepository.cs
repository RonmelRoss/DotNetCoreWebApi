using System.Linq.Expressions;

namespace DotNetCoreWebApi.DAL.Contracts;

public interface IRepository
{
    void Insert<TEntity>(TEntity entity)
        where TEntity : class;
    void Delete<TEntity>(TEntity entity)
        where TEntity : class;
    void Update<TEntity>(TEntity entity)
        where TEntity : class;
    IQueryable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> filter)
        where TEntity : class;
    IQueryable<TEntity> GetAll<TEntity>()
        where TEntity : class;
    TEntity GetById<TEntity>(object id)
        where TEntity : class;
    void Save();
}
