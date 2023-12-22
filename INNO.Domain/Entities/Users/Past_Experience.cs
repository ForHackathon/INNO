using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Users;
public class Past_Experience : Auditable
{
    public long UserId { get; set; }

    public User User { get; set; }

    public string Description { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? Path { get; set; }
}
