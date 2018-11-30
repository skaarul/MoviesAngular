using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.IData;
using MoviesAPI.Model;


namespace MoviesAPI.Data
{
    public class MovieData : IMovieData
    {
        #region Memeber(s)
        private ProjectXDataContext Db;
        #endregion
        #region Constructor(s)
        public MovieData()
        {
            Db = DataContextProvider.GetDataContext();
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// List all the movies in the db
        /// </summary>
        /// <returns></returns>
        public List<MovieModel> GetMovies()
        {
            return (from mo in Db.Movies
             join pr in Db.Producers on mo.ProducerId equals pr.ProducerID
             select new MovieModel
             {
                 MovieName = mo.MovieName,
                 MovieId = mo.MovieId,
                 Plot = mo.Plot,
                 ReleaseYear = mo.ReleaseYear,
                 Actors = GetActorsForMovie(mo.MovieId),
                 ProducerId = mo.ProducerId,
                 ProducerName = pr.ProducerName
             }).ToList();
        }
        /// <summary>
        /// Get the actor for a movie
        /// </summary>
        /// <param name="movieID">Movie ID</param>
        /// <returns></returns>
        private List<ActorModel> GetActorsForMovie(int movieID)
        {
            return (from a in Db.Actors
                    join mv in Db.Movie_Actors on a.ActorId equals mv.ActorID
                    where mv.MovieID == movieID
                    select new ActorModel { ActorId=a.ActorId, ActorName=a.ActorName }).ToList();
        }
        /// <summary>
        /// Add a new movie into DB
        /// </summary>
        /// <param name="movieinput">Movie info</param>
        /// <returns></returns>
        public bool AddMovie(MovieModel movieinput)
        {
            Movie _movie = new Movie();
            _movie.MovieName = movieinput.MovieName;
            _movie.Plot = movieinput.Plot;
            _movie.ReleaseYear = movieinput.ReleaseYear;
            _movie.Producer = Db.Producers.FirstOrDefault(s=>s.ProducerID== movieinput.ProducerId);
            Db.Movies.InsertOnSubmit(_movie);

           List<Movie_Actor> _actors= movieinput.ActorsArray.Select(a => new Movie_Actor { Actor= Db.Actors.FirstOrDefault(s=>s.ActorId== a), Movie= _movie }).ToList();
            Db.Movie_Actors.InsertAllOnSubmit(_actors);

            Db.SubmitChanges();
            return true;
        }
        /// <summary>
        /// Update movie in DB
        /// </summary>
        /// <param name="movieinput"></param>
        /// <returns></returns>
        public bool UpdateMovie(MovieModel movieinput)
        {
            Movie _movie = Db.Movies.FirstOrDefault(m => m.MovieId == movieinput.MovieId);
            _movie.MovieName = movieinput.MovieName;
            _movie.Plot = movieinput.Plot;
            _movie.ReleaseYear = movieinput.ReleaseYear;
            _movie.Producer = Db.Producers.FirstOrDefault(s => s.ProducerID == movieinput.ProducerId);

            if (_movie.Movie_Actors.Count > 0)
            {
                Db.Movie_Actors.DeleteAllOnSubmit(_movie.Movie_Actors);
            }
            List<Movie_Actor> _actors = movieinput.ActorsArray.Select(a => new Movie_Actor { Actor = Db.Actors.FirstOrDefault(s => s.ActorId == a), Movie = _movie }).ToList();
            Db.Movie_Actors.InsertAllOnSubmit(_actors);

            Db.SubmitChanges();
            return true;
        }
        #endregion
    }
}
