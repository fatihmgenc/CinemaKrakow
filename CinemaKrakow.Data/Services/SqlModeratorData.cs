using CinemaKrakow.Data.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CinemaKrakow.Data.Services
{
    public class SqlModeratorData : IModeratorData
    {
        private readonly CinemaKrakowDbContext db;

        public SqlModeratorData(CinemaKrakowDbContext db)
        {
            this.db = db;

        }
        public void Add(Moderator moderator)
        {
            db.Moderators.Add(moderator);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var moderator = Get(id);
            db.Moderators.Remove(moderator);
            db.SaveChanges();
        }

        public void Edit(Moderator moderator)
        {
            var entry = db.Entry(moderator);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public Moderator Get(int id)
        {
            return db.Moderators.FirstOrDefault(r => r.Id == id);
        }

        public Moderator GetByUserName(string username)
        {
            return db.Moderators.FirstOrDefault(r => r.Username == username);
        }
        public IEnumerable<Moderator> GetAll()
        {
            return from r in db.Moderators
                   orderby r.Username
                   select r;
        }
    }
}
