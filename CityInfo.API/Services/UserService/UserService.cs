using CityInfo.API.Data;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CityInfo.API.Services.UserService
{
    public class UserService : IUserService 
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }
        public User AddUser(User newUser)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return _context.Users.FirstOrDefault(user => user == newUser)
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(user => user.UserId == id);
        }
    }
}
