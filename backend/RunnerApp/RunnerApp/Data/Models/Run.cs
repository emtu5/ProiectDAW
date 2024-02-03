using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class Run : BaseEntity
    {
        public required int Time { get; set; }
        public required User User { get; set; }
        public Guid UserId { get; set; }
        public required Category Category { get; set; }
        public Guid CategoryId { get; set; }
    }
}
