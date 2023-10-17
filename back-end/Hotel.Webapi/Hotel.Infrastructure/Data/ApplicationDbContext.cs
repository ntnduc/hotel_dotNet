using Hotel.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ConfigUserEntities();
    }
}