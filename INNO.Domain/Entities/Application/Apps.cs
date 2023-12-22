using INNO.Domain.Commons;
using INNO.Domain.Entities.Organizations;

namespace INNO.Domain.Entities.Application;
public class Apps : Auditable
{
    public string Status { get; set; }

    public long ProductOwnerId { get; set; }

    public long OwnerStartupId { get; set; }

    public OwnerStartup OwnerStartup { get; set; }

    public long OrganizationId { get; set; }

    public Organization Organization { get; set; }

    public long CategoryId { get; set; }

    public Category Category { get; set; }

}
