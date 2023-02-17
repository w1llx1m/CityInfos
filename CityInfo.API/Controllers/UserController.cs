using CityInfo.API.Data;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("[api/controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList(); 
        }

        [HttpGet("{id}")]
        public IEnumerable<User> GetById(int id)
        {
            return _context.Users.Where(user => user.UserId == id);
        }
    }
}