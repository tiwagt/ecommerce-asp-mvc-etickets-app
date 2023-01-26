using etickets.Models;
using Microsoft.EntityFrameworkCore;

namespace etickets.Data.Base
{
    public class MovieBaseRepository : IMovieRepository
    {
        

        public IEnumerable<Movie> Movies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Movie GetMovieById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
