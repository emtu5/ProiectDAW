using AutoMapper;
using RunnerApp.Data.DTOs;
using RunnerApp.Data.Models;
using RunnerApp.Repositories.UserRepository;

namespace RunnerApp.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _userRepository = repository;
            _mapper = mapper;

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
        public async Task<User> AddUser(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.UserSettings = new UserSettings()
            {
                User = user
            };
            // UserSettingsRepository
            await _userRepository.CreateAsync(user);
            await _userRepository.SaveAsync();
            return user;
        }
    }
}
