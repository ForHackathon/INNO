using INNO.Domain.Configuration;
using INNO.Service.DTOs.Startups;
using INNO.Service.Interfaces.IStartups;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace INNO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartupControler : ControllerBase
    {
        private readonly IStartupService _startupService;
        public StartupControler(IStartupService startupService)
        {
            this._startupService = startupService;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateAsync(StartupForCreationDTO sturtup)
            => Ok(await _startupService.CreateAsync(sturtup));

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(long id, StartupForUpdateDTO startup)
          => Ok(await _startupService.UpdateAsync(id, startup));

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParams @params)
           => Ok(await _startupService.GetAsync(@params));

        [HttpGet("{Title}")]
        public async ValueTask<IActionResult> GetAsync([FromRoute] string title)
           => Ok( await _startupService.GetByIdAsync(u => u.Title == title));
        
        [HttpDelete("{Title}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string title)
            => Ok(await _startupService.DeleteAsync(s => s.Title == title));

    }
}
