﻿using INNO.Domain.Commons;
using INNO.Domain.Entities.Organizations;

namespace INNO.Domain.Entities.Users;
public class User : Auditable
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public required string Email { get; set; }

    public string Password { get; set; }

    public long RoleId { get; set; }

    public Role Role { get; set; }
    
    public ICollection<OwnerStartup> ownerStartups { get; set; } 

}
