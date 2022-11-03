using Microsoft.EntityFrameworkCore;

namespace Web_Server_App_Final_Project.Models
{
    public class HobbyContext : DbContext
    {
        public DbSet<Cars>? Cars { get; set; }

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
        }
    }
}
