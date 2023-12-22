using INNO.Domain.Commons;
using INNO.Domain.Entities.Application;
using INNO.Domain.Entities.Users;
namespace INNO.Domain.Entities.Organizations;
public class Organization : Auditable
{

    public long UserId { get; set; }

    public User User { get; set; }

    public string Title { get; set; }

    public string OrganizationDescription { get; set; }

    public decimal AllocatedMoney { get; set; }

    public decimal ExpectedBenefit { get; set; }

    public long CategoryId { get; set; }

    public Category Category { get; set; }
}
