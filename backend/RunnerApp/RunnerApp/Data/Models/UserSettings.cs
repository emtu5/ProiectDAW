using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class UserSettings : BaseEntity
    {
        // TODO: think of actual user settings
        public required User User { get; set; }
        public Guid UserId { get; set; }
    }
}
