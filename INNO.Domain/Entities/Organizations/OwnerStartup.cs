using INNO.Domain.Commons;
using INNO.Domain.Entities.Attachments;
using INNO.Domain.Entities.Categories;
using INNO.Domain.Entities.Users;

namespace INNO.Domain.Entities.Organizations;
public class OwnerStartup : Auditable
{
    public long UserId { get; set; }

    public User User { get; set; }

    public string Title { get; set; }

    public string StartupDescription { get; set; }

    public long AttachmentId { get; set; }
    public Attachment attachments { get; set; }
    public string? Path { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; }

}
