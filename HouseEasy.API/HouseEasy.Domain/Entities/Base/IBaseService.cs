namespace HouseEasy.Domain.Entities.Base
{
    public interface IBaseService<T> where T : class
    {
        Task<T> Create(T entity);

        Task<T> Delete(T entity);

        IEnumerable<T> GetAll();

        T GetById(int id);

        Task<T> Update(T entity);
    }
}
