namespace CityInfo.API.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string BirthDate { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilePicUrl { get; set; }
    }
}
