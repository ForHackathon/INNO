using INNO.Domain.Commons;
using INNO.Domain.Entities.Organizations;

namespace INNO.Domain.Entities.Application;
public class OrganizationApps : Auditable
{
    public long InvesterId { get; set; }

    public long OwnerStartupId { get; set; }

    public OwnerStartup OwnerStartup { get; set; }

    public long OrganizationId { get; set; }

    public Organization Organization { get; set; }

}
