using INNO.Service.Atributes;
using System.ComponentModel.DataAnnotations;

namespace INNO.Service.DTOs.Users;

public class UserForChangePasswordDTO
{
    [Required]
    public string OldPassword { get; set; }
    [Required, UserPassword]
    public string NewPassword { get; set; }
}
