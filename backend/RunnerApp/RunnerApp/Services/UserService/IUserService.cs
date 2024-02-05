using RunnerApp.Data.DTOs;
using RunnerApp.Data.Models;

namespace RunnerApp.Services.UserService
{
    public interface IUserService
    {
        public Task<List<User>> GetUsers();
        public Task<User> GetUserByUsername(string username);
        public Task<User> DeleteUserByUsername(string username);
        /*public Task<User> AddUser(UserDTO userDto);*/
    }
}
