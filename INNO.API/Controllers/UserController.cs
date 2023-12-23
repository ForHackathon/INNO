using INNO.Service.Interfaces.IUsers;
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

    }
}
