using INNO.Domain.Commons;
using System.Linq.Expressions;

namespace INNO.Data.IRepositories;
public interface IGenericRepository<T> where T : Auditable
{
    public Task<T> CreateAsync(T entity);

    public Task<T> UpdateAsync(T entity);

    public Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);

    public Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null);

    IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression,
        string[] includes = null,
        bool isTracking = true);

    public Task SaveChangesAsync();
}
