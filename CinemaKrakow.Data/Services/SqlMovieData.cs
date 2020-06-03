using CinemaKrakow.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


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
            var Movei = Get(id);
            db.Movies.Remove(Movei);
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
