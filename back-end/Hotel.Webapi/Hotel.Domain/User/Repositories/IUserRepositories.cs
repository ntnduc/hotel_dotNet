using DaLatFood.Domain.Core.IRepositoriesCore;

namespace Hotel.Domain.User.Repositories;

public interface IUserRepositories : IRepository<Entity.User, Guid>
{
}