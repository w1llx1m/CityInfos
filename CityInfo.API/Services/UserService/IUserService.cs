using CityInfo.API.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CityInfo.API.Services.UserService
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(int id);
        User AddUser(User newUser);    
    }
}
