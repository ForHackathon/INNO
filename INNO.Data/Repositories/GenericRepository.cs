using INNO.Data.DbContexts;
using INNO.Data.IRepositories;
using INNO.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

    public async Task<T> CreateAsync(T entity) =>
            (await appDbContext.AddAsync(entity)).Entity;

    public async Task<bool> DeleteAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
    {
        var entity = await GetAsync(expression);

        if (entity == null)
            return false;

        dbSet.Remove(entity);

        return true;
    }

    public IQueryable<T> GetAllAsync(System.Linq.Expressions.Expression<Func<T,bool>> expression,
        string[] includes = null,
        bool isTracking = true)
    {
        IQueryable<T> query = expression is null ? dbSet : dbSet.Where(expression);

        if (includes != null)
            foreach (var include in includes)
                if (!string.IsNullOrEmpty(include))
                    query = query.Include(include);

        if (!isTracking)
            query = query.AsNoTracking();

        return query;
    }

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression, string[] includes = null) =>
         await GetAllAsync(expression, includes, false).FirstOrDefaultAsync();

    public async Task SaveChangesAsync() =>
        await appDbContext.SaveChangesAsync();

    public async Task<T> UpdateAsync(T entity) =>
        dbSet.Update(entity).Entity;
}
