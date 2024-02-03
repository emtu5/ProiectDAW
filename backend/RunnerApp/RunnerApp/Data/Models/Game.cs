using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class Game : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Moderator>? Moderator { get; set; }
    }
}
