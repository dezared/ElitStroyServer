using ElitStroyServer.Model;
using Microsoft.EntityFrameworkCore;

namespace ElitStroyServer
{
    public class ApplicationContext : DbContext
    { 
        public DbSet<User> User { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
