
using Microsoft.AspNetCore.Http;

namespace INNO.Service.DTOs.Users;
public class UserForCreationDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Email { get; set; }
    
    public string Role { get; set; }

    public string Password { get; set; }

    public IFormFile? Image { get; set; }
}
