using RunnerApp.Data.DTOs;
using RunnerApp.Data.Models;
using RunnerApp.Repositories.UserRepository;

namespace RunnerApp.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
            
        }
        public async Task<List<User>> GetUsers() 
        {
            return await _userRepository.GetAll();
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _userRepository.FindByUsername(username);
        }
        public async Task<User> DeleteUserByUsername(string username) 
        {
            var user = await _userRepository.FindByUsername(username);
            _userRepository.Delete(user);
            return user;
        }
        /*public Task<User> AddUser(UserDTO userDto)
        {
            
        }*/
    }
}
