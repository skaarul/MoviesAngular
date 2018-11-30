using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.IBusiness;
using MoviesAPI.IData;
using MoviesAPI.Model;
using MoviesAPI.Data;

namespace MoviesAPI.Business
{
    /// <summary>
    /// Movies business
    /// </summary>
    public class MovieBusiness : IMovie
    {
        #region Memeber(s)
        private IMovieData movieData;
        #endregion
        #region Constructor(s)
        public MovieBusiness()
        {
            movieData = new MovieData();
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// Get list of movies
        /// </summary>
        /// <returns></returns>
        public List<MovieModel> GetMovies()
        {
            return movieData.GetMovies();
        }
        /// <summary>
        /// Add a new movie
        /// </summary>
        /// <param name="movieinput"></param>
        /// <returns></returns>
        public bool AddMovie(MovieModel movieinput)
        {
           return movieData.AddMovie(movieinput);
        }
        /// <summary>
        /// Update movie
        /// </summary>
        /// <param name="movieinput"></param>
        /// <returns></returns>
        public bool UpdateMovie(MovieModel movieinput)
        {
            return movieData.UpdateMovie(movieinput);
        }
        #endregion
    }
}
