using INNO.Domain.Configuration;
using INNO.Domain.Entities.Users;
using INNO.Service.DTOs.Users;
using INNO.Service.Interfaces.IUsers;
using INNO.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace INNO.API.Controllers
{
    [Controller]
    [Route("UserController")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            this._service = service;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync(UserForCreationDTO userForCreationDTO)
           => Ok(await _service.CreateAsync(userForCreationDTO));

        [HttpPut("{id}")]
        public async ValueTask<IActionResult> UpdateAsync([FromRoute] long id, UserForUpdateDTO userForUpdateDTO)
           => Ok(await _service.UpdateAsync(id, userForUpdateDTO));

        [HttpPatch("Password")]
        public async ValueTask<IActionResult> ChangePasswordAsync(UserForChangePasswordDTO userForChangePasswordDTO)
           => Ok(await _service.ChangePasswordAsync(userForChangePasswordDTO));

        [HttpGet, Authorize]
        public async ValueTask<IActionResult> GetAll([FromQuery] PaginationParams @params)
          => Ok(await _service.GetAsync(@params));

        [HttpGet("{id}")]
        public async ValueTask<IActionResult> GetAsync([FromRoute] long id)
          => Ok(await _service.GetByIdAsync(u => u.Id == id));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] long id)
            => Ok(await _service.DeleteAsync(u => u.Id == id));





    }
}
