using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Repositories {
    public class FootballContext: DbContext {
        public FootballContext(string connString): base(connString) { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
    }
}
