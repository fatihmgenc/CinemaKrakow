using CinemaKrakow.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKrakow.Data.Services
{
    public class SqlMovieData : IMovieData
    {
        private readonly CinemaKrakowDbContext db;

        public SqlMovieData(CinemaKrakowDbContext db )
        {
            this.db = db;
        }
        public void Add(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Moveis = Get(id);
            db.Movies.Remove(Moveis);
            db.SaveChanges();
        }

        public void Edit(Movie movie)
        {
            var entry = db.Entry(movie);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public Movie Get(int id)
        {
            return db.Movies.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return from r in db.Movies
                   orderby r.Name
                   select r;
        }
    }
}
