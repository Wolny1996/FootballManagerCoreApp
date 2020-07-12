using FootballManagerApp3_1.Domain;
using Microsoft.EntityFrameworkCore;

namespace FootballManagerApp3_1.Data
{
    public class FootballManagerContext: DbContext
    {
        public FootballManagerContext()
        {

        }

        public FootballManagerContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<PitchPosition> PitchPositions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Data Source=localhost,5000;Initial Catalog=FootballManagerApp3_1db;User ID=SA;Password=SqlPassword123!",
                        options => options.MaxBatchSize(150));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClubTournament>().HasKey(s => new { s.ClubId, s.TournamentId });
            modelBuilder.Entity<Stadium>().ToTable("Stadiums");
        }
    }
}