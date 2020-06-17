using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fandom.Model;
using fandom.WebAPI.Database;
using fandom.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace fandom.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUsersService _userService;

        public UserController(IUsersService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<MUser>> Get() => _userService.Get();
    }
}
