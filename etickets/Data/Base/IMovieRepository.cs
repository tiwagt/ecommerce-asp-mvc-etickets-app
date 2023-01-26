using etickets.Models;

namespace etickets.Data.Base
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Movies { get; set; }

        Movie GetMovieById(int id);
    }
}
