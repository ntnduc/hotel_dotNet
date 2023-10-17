using DaLatFood.Infrastructure.Core.RepositoryService;
using Hotel.Domain.User.Repositories;
using Hotel.Infrastructure.Data;

namespace Hotel.Infrastructure.Repositories.User;

public class UserRepositories: EfCoreRepository<Domain.User.Entity.User, Guid>, IUserRepositories
{
    public UserRepositories(ApplicationDbContext dbContextProvider) : base(dbContextProvider)
    {
    }
}