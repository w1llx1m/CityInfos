using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpGet]
        public User Get()
        {
            return new User(){
                UserId = 1,
                UserName = "william",
                BirthDate = "10/10/2002",
                Password = "12345",
                Email = "will@gmail.com",
                ProfilePicUrl = "endereço url aqui"
            };
        }
    }
}