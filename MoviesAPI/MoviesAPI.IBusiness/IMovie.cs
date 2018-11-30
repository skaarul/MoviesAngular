using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.Model;

namespace MoviesAPI.IBusiness
{
    /// <summary>
    /// Movies business actions
    /// </summary>
    public interface IMovie
    {
        /// <summary>
        /// List movies
        /// </summary>
        /// <returns></returns>
        List<MovieModel> GetMovies();
        /// <summary>
        /// Add a new movie
        /// </summary>
        /// <param name="movieinput"></param>
        /// <returns></returns>
        bool AddMovie(MovieModel movieinput);
        bool UpdateMovie(MovieModel movieinput);
    }
}
