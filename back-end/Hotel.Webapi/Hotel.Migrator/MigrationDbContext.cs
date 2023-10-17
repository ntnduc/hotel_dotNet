
using Hotel.Domain.User.Entity;
using Hotel.Infrastructure.EntityConfigurations;

namespace DaLatFood.Migrator;

public class MigrationDbContext : DbContext
{
    public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigUserEntities();
    }

    public override int SaveChanges()
    {
        return base.SaveChanges();
    }

}