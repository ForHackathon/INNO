
using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Users;
public class PastExperience : Auditable
{
    public long UserId { get; set; }

    public User User { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string? Path { get; set; }
}
