using CinemaKrakow.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaKrakow.Data.Services
{
    public interface IMovieData
    {
        IEnumerable<Movie> GetAll();
        Movie Get(int id);

        void Edit(Movie movie);
        void Add(Movie movie);
        void Delete(int id);
    }
}
