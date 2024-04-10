using Microsoft.EntityFrameworkCore;

namespace SuperHero.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Hero> Heroes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>().HasData(new Hero { Id = 1, Name = "Bruce Wayne", Title = "Batman", Description = "A boy who lost his parent and choose the path of vengence" },
            new Hero { Id = 2, Name = "Peter Parker", Title = "Spider-man", Description = "A friendly neighbourhood" },
            new Hero { Id = 3, Name = "Tony Stark", Title = "Iron-man", Description = "A Techie save the world by creating suit" });

        }
    }
}
