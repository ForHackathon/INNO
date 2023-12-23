
using INNO.Domain.Configuration;
using INNO.Service.DTOs.PastExperiences;
using INNO.Service.Interfaces.IUsers;
using Microsoft.AspNetCore.Mvc;

namespace INNO.API.Controllers
{
    [Controller]
    [Route("PastExperienceController")]
    public class PastExperienceController : ControllerBase 
    {
        private readonly IPastExperienceService pastExperience;
        
        public PastExperienceController(IPastExperienceService pastExperience)
        {
            this.pastExperience = pastExperience;
        }

        [HttpPost]
        public async ValueTask<IActionResult>CreateAsync(PastExperienceForCreationDTO creationDTO)
            =>Ok(await  pastExperience.CreateAsync(creationDTO));

        [HttpPut]
        public async ValueTask<IActionResult>UpdateAsync(PastExperienceForUpdateDTO updateDTO)
            =>Ok(await pastExperience.UpdateAsync(updateDTO));

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync([FromBody] PaginationParams @paginationParams)
            => Ok(await pastExperience.GetAsync(@paginationParams));

        [HttpGet]
        public async ValueTask<IActionResult> GetAsync([FromRoute] string title)
            => Ok(await pastExperience.GetByIdAsync(p => p.Title == title));

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAsync([FromRoute,] string title)
            => Ok(await pastExperience.DeleteAsync(t => t.Title == title));

    }
}
