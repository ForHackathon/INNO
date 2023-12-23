using Microsoft.AspNetCore.Http;

namespace INNO.Service.DTOs.Users;
public class UserForViewDTO
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Role { get; set; }

    public IFormFile? Image { get; set; }

}
