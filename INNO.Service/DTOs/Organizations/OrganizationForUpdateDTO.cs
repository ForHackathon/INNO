﻿namespace INNO.Service.DTOs.Organizations;
public class OrganizationForUpdateDTO
{
    public string Title {get; set;}
    public string OrganizationDescription { get; set; }

    public decimal AllocatedMoney { get; set; }

    public decimal ExpectedBenefit { get; set; }
}
