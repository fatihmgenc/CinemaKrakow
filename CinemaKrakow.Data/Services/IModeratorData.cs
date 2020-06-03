using CinemaKrakow.Data.Models;
using System.Collections.Generic;


namespace CinemaKrakow.Data.Services
{
    public interface IModeratorData
    {
        IEnumerable<Moderator> GetAll();
        Moderator Get(int id);
        Moderator GetByUserName(string username);
        void Edit(Moderator movie);
        void Add(Moderator movie);
        void Delete(int id);
    }
}
