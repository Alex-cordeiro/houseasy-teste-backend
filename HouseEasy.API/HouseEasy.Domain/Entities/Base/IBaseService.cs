namespace HouseEasy.Domain.Entities.Base
{
    public interface IBaseService<T> where T : class
    {
        Task<T> Create(T entity);

        bool Delete(int id);

        IEnumerable<T> GetAll();

        T GetById(int id);

        bool Update(T entity);
    }
}
