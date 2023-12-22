using INNO.Domain.Commons;
using INNO.Domain.Entities.User;

namespace INNO.Domain.Entities.Users;
public class User : Auditable
{
    public long UserId { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public required string Email { get; set; }

    public string Password { get; set; }

    public long RoleId { get; set; }

    public Role Role { get; set; }

}
