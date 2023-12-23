using Microsoft.AspNetCore.Http;

namespace INNO.Service.DTOs.PastExperiences;
public class PastExperienceForViewDTO
{
    public string Title { get; set; }

    public string Description { get; set; }

    public string? Path { get; set; }

    public IFormFile File { get; set; }
}
