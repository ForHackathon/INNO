using System.Linq.Expressions;

namespace INNO.Data.IRepositories;
public interface IGenericRepository<T> where T : class
{
    ValueTask<T> CreateAsync(T entity);

    ValueTask<T> UpdateAsync(T entity);

    ValueTask<bool> DeleteAsync(Expression<Func<T, bool>> expression);

    ValueTask<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null);

    IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression,
        string[] includes = null,
        bool IsTracking = true);

    public ValueTask SaveChangesAsync();
}
