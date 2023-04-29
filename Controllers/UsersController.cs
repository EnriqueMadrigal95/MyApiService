using DataAccess.Enties;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace MyApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {

            List<User> listUsers = await _userService.GetAll();

            return Ok(listUsers);
        }

        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<User>> Create(User user)
        {

            User createdUser = await _userService.Create(user);

            return Ok(createdUser);
        }
    }
}
