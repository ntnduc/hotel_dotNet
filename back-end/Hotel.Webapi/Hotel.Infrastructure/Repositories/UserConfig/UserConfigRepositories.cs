using DaLatFood.Infrastructure.Core.RepositoryService;
using Hotel.Domain.User.Repositories;
using Hotel.Infrastructure.Data;

namespace Hotel.Infrastructure.Repositories.UserConfig;

public class UserConfigRepositories :  EfCoreRepository<Domain.User.Entity.UserConfig, Guid>, IUserConfigRepositories
{
    protected UserConfigRepositories(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
}