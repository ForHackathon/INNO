using INNO.Domain.Commons;

namespace INNO.Domain.Entities.Application;
public class OrganizationApps : Auditable
{
    public long InvesterId { get; set; }

    public long OwnerStartupId { get; set; }

    public long OrganizationId { get; set; }
}
