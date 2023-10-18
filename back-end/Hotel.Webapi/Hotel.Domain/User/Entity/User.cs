using DaLatFood.Domain.Core;

namespace Hotel.Domain.User.Entity;

public class User : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public Guid UserConfigId { get; set; }
}