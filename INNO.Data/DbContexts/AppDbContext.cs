using INNO.Domain.Entities.Application;
using INNO.Domain.Entities.Categories;
using INNO.Domain.Entities.Categories;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace INNO.Data.DbContexts;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<PastExperience> Past_Experiences { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<UserRole> UserRoles { get; set; }
    public virtual DbSet<Organization> Organizations { get; set; }
    public virtual DbSet<OwnerStartup> OwnerStartups { get; set; }
    public virtual DbSet<Apps> Appss { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<OrganizationApps> OrganizationApps { get; set; }

    protected override void  OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique(true);

        modelBuilder.Entity<Organization>()
            .HasIndex(o => o.Title)
            .IsUnique(true);

        modelBuilder.Entity<Category>()
            .HasIndex(o => o.Title)
            .IsUnique(true);

        modelBuilder.Entity<OwnerStartup>()
            .HasIndex(o => o.Title)
            .IsUnique(true);


    }
}
