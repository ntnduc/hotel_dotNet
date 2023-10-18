using Hotel.Domain.User.Entity;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infrastructure.EntityConfigurations;

public static class UserEntityConfiguration
{
    private const string UserSchemaName = "UserSchema";
    
    public static void ConfigUserEntities(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.ToTable("User", UserSchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("NEWID()");
        });
    }
}