using Microsoft.EntityFrameworkCore;
using RunnerApp.Data;
using RunnerApp.Data.Models;
using RunnerApp.Repositories.GenericRepository;

namespace RunnerApp.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(RunnerContext runnerContext) : base(runnerContext) { }
        public async Task<User> FindByUsername(string username)
        {
            return (await _table.FirstOrDefaultAsync(u => u.Username.Equals(username)))!;
        }
    }
}
