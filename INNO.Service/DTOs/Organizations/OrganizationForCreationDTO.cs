namespace INNO.Service.DTOs.Organizations;
public class OrganizationForCreationDTO
{
    public string Title { get; set; }

    public string OrganizationDescription { get; set; }

    public decimal AllocatedMoney { get; set; }

    public decimal ExpectedBenefit { get; set; }
}
