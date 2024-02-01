using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class User : BaseEntity
    {
        public required string Username { get; set; }
        public string? Description { get; set; }
        public required string Email { get; set; }
        public required UserSettings UserSettings { get; set; }
        public ICollection<Run>? Runs { get; set; }
        public ICollection<Moderator>? Moderator { get; set; }
    }
}
