using Microsoft.AspNetCore.Http;

namespace INNO.Service.DTOs.Organizations;
public class OrganizationForViewDTO
{
    public string Title { get; set; }

    public string OrganizationDescription { get; set; }

    public decimal AllocatedMoney { get; set; }

    public decimal ExpectedBenefit { get; set; }

    public IFormFile? Image { get; set; }
}
