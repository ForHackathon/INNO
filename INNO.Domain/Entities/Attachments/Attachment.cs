using INNO.Domain.Commons;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;

namespace INNO.Domain.Entities.Attachments;

public  class Attachment : Auditable
{
    public string Name { get; set; }
    public string Path {  get; set; }

    public User? User { get; set; }
    public OwnerStartup? OwnerStartup { get; set; }
    public Organization? Organization { get; set; }

}
