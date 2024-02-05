using RunnerApp.Data.Models;
using RunnerApp.Repositories.GenericRepository;

namespace RunnerApp.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> FindByUsername(string username);
    }
}
