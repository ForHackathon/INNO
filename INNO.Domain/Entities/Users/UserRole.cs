using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Users;
public class UserRole : Auditable
{
    public long RoleId { get; set; }
    public Role Role { get; set; }


    public long UserId { get; set; }
    public User User { get; set; }



}
