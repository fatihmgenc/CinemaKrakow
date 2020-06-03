using CinemaKrakow.Data.Models;
using System.Data.Entity;


namespace CinemaKrakow.Data.Services
{
    public class CinemaKrakowDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Moderator> Moderators { get; set; }

    }
}
