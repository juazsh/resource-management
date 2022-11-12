using Microsoft.EntityFrameworkCore;
using ResourceManagement.Api.Entities;

namespace ResourceManagement.Api.DAL;

public class ResourceManagementDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }

    public ResourceManagementDbContext(DbContextOptions<ResourceManagementDbContext> option)
        : base(option)
    {}
   

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Company>()
            .ToTable("Companies")
            .HasKey(x => x.Id);

        modelBuilder.Entity<Company>()
            .HasIndex(x => x.Name)
            .IsUnique();
        
        modelBuilder.Entity<Company>()
            .HasMany<Employee>(x => x.Employees)
            .WithOne()
            .HasForeignKey(x => x.CompanyId);

        modelBuilder.Entity<Employee>()
            .ToTable("Employees")
            .HasKey(x => x.Id);
    }
}