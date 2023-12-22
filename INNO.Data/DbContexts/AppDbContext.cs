using INNO.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace INNO.Data.DbContexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public virtual DbSet<User>
}
