using DaLatFood.Domain.Core.IRepositoriesCore;
using Hotel.Domain.User.Entity;

namespace Hotel.Domain.User.Repositories;

public interface IUserConfigRepositories : IRepository<UserConfig, Guid>
{
}