using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.Model;

namespace MoviesAPI.IData
{
    public interface IMovieData
    {
        List<MovieModel> GetMovies();
        bool AddMovie(MovieModel movieinput);
        bool UpdateMovie(MovieModel movieinput);
    }
}
