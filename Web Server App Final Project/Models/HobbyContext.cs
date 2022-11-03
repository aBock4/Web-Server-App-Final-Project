using Microsoft.EntityFrameworkCore;

namespace Web_Server_App_Final_Project.Models
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Cars>? Cars { get; set; }
        public DbSet<Games>? Games { get; set; }
        public DbSet<Trumpet>? Trumpets { get; set; }
    }
}
