using DaLatFood.Domain.Core;

namespace Hotel.Domain.User.Entity;

public class UserConfig : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string Password { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}