using Microsoft.AspNetCore.Http;

namespace INNO.Service.DTOs.Startups;
public class StartupForCreationDTO
{
    public string Title { get; set; }

    public string StartupDescription { get; set; }

    public string? Path { get; set; }
    public IFormFile? Image { get; set; }

}
