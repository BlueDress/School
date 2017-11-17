using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data.Models;
using System.IO;

namespace P03_FootballBetting.Data
{
    public class FootballBettingContext : DbContext
    {
        public FootballBettingContext()
        {

        }

        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = File.ReadAllText("C:\\Program Files (x86)\\Notepad++\\Instructions.txt");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bet>(e =>
            {
                e.HasKey(b => b.BetId);

                e.Property(b => b.DateTime).HasColumnType("datetime2");

                e.HasOne(b => b.User).WithMany(u => u.Bets).HasForeignKey(b => b.UserId);

                e.HasOne(b => b.Game).WithMany(g => g.Bets).HasForeignKey(b => b.GameId);
            });

            modelBuilder.Entity<Color>(e =>
            {
                e.HasKey(c => c.ColorId);

                e.Property(c => c.Name).IsRequired().IsUnicode();
            });

            modelBuilder.Entity<Country>(e =>
            {
                e.HasKey(c => c.CountryId);

                e.Property(c => c.Name).IsRequired().IsUnicode();
            });

            modelBuilder.Entity<Game>(e =>
            {
                e.HasKey(g => g.GameId);
                
                e.Property(g => g.DateTime).HasColumnType("datetime2");

                e.HasOne(g => g.HomeTeam).WithMany(ht => ht.HomeGames).HasForeignKey(g => g.HomeTeamId).OnDelete(DeleteBehavior.Restrict);

                e.HasOne(g => g.AwayTeam).WithMany(at => at.AwayGames).HasForeignKey(g => g.AwayTeamId).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Player>(e =>
            {
                e.HasKey(p => p.PlayerId);

                e.Property(p => p.Name).IsRequired();

                e.Property(p => p.SquadNumber).IsRequired();

                e.Property(p => p.IsInjured).HasDefaultValue(false);

                e.HasOne(p => p.Team).WithMany(t => t.Players).HasForeignKey(p => p.TeamId);

                e.HasOne(p => p.Position).WithMany(p => p.Players).HasForeignKey(p => p.PositionId);
            });

            modelBuilder.Entity<PlayerStatistic>(e =>
            {
                e.HasKey(ps => new { ps.GameId, ps.PlayerId });

                e.HasOne(ps => ps.Game).WithMany(g => g.PlayerStatistic).HasForeignKey(ps => ps.GameId);

                e.HasOne(ps => ps.Player).WithMany(p => p.PlayerStatistic).HasForeignKey(ps => ps.PlayerId);
            });

            modelBuilder.Entity<Position>(e =>
            {
                e.HasKey(p => p.PositionId);

                e.Property(p => p.Name).IsRequired().IsUnicode();
            });

            modelBuilder.Entity<Team>(e =>
            {
                e.HasKey(t => t.TeamId);

                e.Property(t => t.Name).IsRequired().IsUnicode();

                e.Property(t => t.LogoUrl).IsRequired(false).IsUnicode(false);

                e.Property(t => t.Initials).IsRequired().IsUnicode().HasColumnType("CHAR(3)");

                e.Property(t => t.Budget).IsRequired(false);

                e.HasOne(t => t.PrimaryKitColor).WithMany(c => c.PrimaryKitTeams).HasForeignKey(t => t.PrimaryKitColorId).OnDelete(DeleteBehavior.Restrict);

                e.HasOne(t => t.SecondaryKitColor).WithMany(c => c.SecondaryKitTeams).HasForeignKey(t => t.SecondaryKitColorId).OnDelete(DeleteBehavior.Restrict);

                e.HasOne(t => t.Town).WithMany(t => t.Teams).HasForeignKey(t => t.TownId);
            });

            modelBuilder.Entity<Town>(e =>
            {
                e.HasKey(t => t.TownId);

                e.Property(t => t.Name).IsRequired().IsUnicode();

                e.HasOne(t => t.Country).WithMany(c => c.Towns).HasForeignKey(t => t.CountryId);
            });

            modelBuilder.Entity<User>(e =>
            {
                e.HasKey(u => u.UserId);

                e.Property(u => u.Username).IsRequired().IsUnicode();

                e.Property(u => u.Password).IsRequired().IsUnicode();

                e.Property(u => u.Email).IsRequired().IsUnicode();

                e.Property(u => u.Name).IsRequired().IsUnicode();
                
                e.Property(u => u.Balance).IsRequired();
            });
        }
    }
}
