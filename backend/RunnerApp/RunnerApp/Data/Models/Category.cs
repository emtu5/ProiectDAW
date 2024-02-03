using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class Category : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<Run>? Runs { get; set; }
        public required Game Game { get; set; }
        public Guid GameId { get; set; }
    }
}
