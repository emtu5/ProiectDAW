namespace RunnerApp.Data.Models
{
    public class Moderator
    {
        public Guid UserId { get; set; }
        public required User User { get; set; }
        public Guid GameId { get; set; }
        public required Game Game { get; set; }
    }
}
