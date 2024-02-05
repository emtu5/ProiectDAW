using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class UserSettings : BaseEntity
    {
        public string? UsernameColor { get; set; }
        public string? Country { get; set; }
        public required User User { get; set; }
        public Guid UserId { get; set; }
    }
}
