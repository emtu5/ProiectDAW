using RunnerApp.Data.Models.Base;

namespace RunnerApp.Data.Models
{
    public class Game : BaseEntity
    {
        public required string Name;
        public string? Description;
        public DateTime? ReleaseDate;
        public ICollection<Category>? Categories { get; set; }
        public ICollection<Moderator>? Moderator { get; set; }
    }
}
