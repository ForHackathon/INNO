using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace INNO.Service.DTOs.Users;
public class UserForCreatingDTO
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }
    
    public string Role { get; set; }
    
    public string Password { get; set; }
}
