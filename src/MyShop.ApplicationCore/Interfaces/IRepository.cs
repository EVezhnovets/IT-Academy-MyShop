using System.Linq.Expressions;

namespace MyShop.ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T? GetById(int id);
        void Update(T entity);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
