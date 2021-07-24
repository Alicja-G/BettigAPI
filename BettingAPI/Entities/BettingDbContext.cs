using Microsoft.EntityFrameworkCore;

namespace BettingAPI.Entities
{
    public class BettingDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventAdress> EventAdresses { get; set; }
        public DbSet<Confrontation> GetConfrontations { get; set; }

        private string _connectionString =
            "Server=localhost;Database=BettingDb;Trusted_Connection=True";

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
