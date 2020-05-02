using CinemaKrakow.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKrakow.Data.Services
{
    public class CinemaKrakowDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}
