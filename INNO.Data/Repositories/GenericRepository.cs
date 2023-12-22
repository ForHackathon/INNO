using INNO.Data.DbContexts;
using INNO.Data.IRepositories;
using INNO.Domain.Commons;
using Microsoft.EntityFrameworkCore;

namespace INNO.Data.Repositories;
public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
{
    private readonly AppDbContext appDbContext;
    private readonly DbSet<T> dbSet;

    public GenericRepository(AppDbContext appDbContext, DbSet<T> dbSet)
    {
        this.appDbContext = appDbContext;
        this.dbSet = dbSet;
    }

    public async ValueTask<T> CreateAsync(T entity) =>
            (await appDbContext.AddAsync(entity)).Entity;

    public async ValueTask<bool> DeleteAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
    {
        var entity = await GetAsync(expression);

        if (entity == null)
            return false;

        dbSet.Remove(entity);

        return true;
    }

    public IQueryable<T> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression, string[] includes = null, bool IsTracking = true)
    {
        throw new NotImplementedException();
    }

    public ValueTask<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression, string[] includes = null)
    {
        throw new NotImplementedException();
    }

    public ValueTask SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
