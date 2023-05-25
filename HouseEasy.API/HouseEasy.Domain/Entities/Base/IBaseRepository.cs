using System.Linq.Expressions;

namespace HouseEasy.Domain.Entities.Base
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Add(T entity);
        IQueryable<T> Get(Expression<Func<T, bool>> expression = null);
        Task<T> Remove(T entity);
        Task<T> Update(T entity);
    }
}
