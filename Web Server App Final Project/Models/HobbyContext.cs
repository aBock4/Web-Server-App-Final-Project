using Microsoft.EntityFrameworkCore;

namespace Web_Server_App_Final_Project.Models
{
    public class HobbyContext : DbContext
    {
        public DbSet<Cars>? Cars { get; set; }
        public DbSet<Games>? Games { get; set; }
        public DbSet<Trumpet>? Trumpet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>().HasData(
                new Cars
                {
                    CarId = 1,
                    Year = 1969,
                    Make = "Ford",
                    Model = "Mustang Coupe"
                },
                new Cars
                {
                    CarId = 2,
                    Year = 2010,
                    Make = "Ford",
                    Model = "Focus SE"
                },
                new Cars
                {
                    CarId = 3,
                    Year = 1973,
                    Make = "Jeep",
                    Model = "J20"
                }
            );

            modelBuilder.Entity<Games>().HasData(
                new Games
                {
                    GameID = 1,
                    Name = "Tekken 7",
                    Genre = "Fighting",
                    Platform = "PC, PS4, Xbox",
                    Year = 2017
                },
                new Games
                {
                    GameID = 2,
                    Name = "Detroit Become Human",
                    Genre = "Action-Adventure",
                    Platform = "PC, PS4, Xbox",
                    Year = 2018
                },
                new Games
                {
                    GameID = 3,
                    Name = "Hollow Knight",
                    Genre = "Adventure, Indie",
                    Platform = "PC, PS4, Xbox",
                    Year = 2017
                }
            );

            modelBuilder.Entity<Trumpet>().HasData(
                new Trumpet
                {
                    HornID = 1,
                    Model = "Yamaha",
                    Make = "Advantage",
                    Year = 2012
                },
                new Trumpet
                {
                    HornID = 2,
                    Model = "Yamaha",
                    Make = "Xeno",
                    Year = 2022
                },
                new Trumpet
                {
                    HornID = 3,
                    Model = "Bach",
                    Make = "Stradivarius",
                    Year = 2002
                }
                );
        }
    }
}
