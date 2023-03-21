using CityInfo.API.Data;
using CityInfo.API.Models;
using CityInfo.API.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getAll")]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            return  Ok(_userService.GetAllUsers());
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            return Ok(_userService.GetUserById(id));
        }

        [HttpPost]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            return Ok(_userService.AddUser(user));
        }
    }
}