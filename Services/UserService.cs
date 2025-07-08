using EventEase.Models;

namespace EventEase.Services
{
    public class UserService
    {
        public UserModel CurrentUser { get; set; } = new();
    }
}
