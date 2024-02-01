using Microsoft.EntityFrameworkCore;
using RunnerApp.Data.Models;

namespace RunnerApp.Data
{
    public class RunnerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserSettings> UsersSettings { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Run> Runs { get; set; }
        public DbSet<Moderator> Moderators { get; set; }

        public RunnerContext(DbContextOptions<RunnerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserSettings)
                .WithOne(us => us.User)
                .HasForeignKey<UserSettings>(us => us.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Runs)
                .WithOne(r => r.User);

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Categories)
                .WithOne(c => c.Game);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Runs)
                .WithOne(r => r.Category);

            modelBuilder.Entity<Moderator>().HasKey(m => new { m.UserId, m.GameId });

            modelBuilder.Entity<Moderator>()
                .HasOne(m => m.User)
                .WithMany(u => u.Moderator)
                .HasForeignKey(m => m.UserId);

            modelBuilder.Entity<Moderator>()
                .HasOne(m => m.Game)
                .WithMany(g => g.Moderator)
                .HasForeignKey(m => m.GameId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
