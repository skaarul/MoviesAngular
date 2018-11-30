using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoviesAPI.Model;
using MoviesAPI.IBusiness;
using MoviesAPI.Business;
using MoviesAPI.Filters;

namespace MoviesAPI.Controllers
{
    [APIExceptionFilter]
    public class MovieController : ApiController
    {
        #region Member(s)
        private IMovie iMovie;
        #endregion
        #region Constructor(s)
        public MovieController(IMovie _clsMovie)
        {
            iMovie = _clsMovie;
        }
        #endregion
        #region ActionMethod(s)
        /// <summary>
        /// Get the movies list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {
           var _result= iMovie.GetMovies();
           return Request.CreateResponse(HttpStatusCode.OK, _result);
        }
        /// <summary>
        /// Create a movie record
        /// </summary>
        /// <param name="movie">movie input</param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post(MovieModel movie)
        {
           var _result= iMovie.AddMovie(movie);
           return Request.CreateResponse(HttpStatusCode.OK, _result);
        }
        /// <summary>
        /// Update movie record
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPut]
        public HttpResponseMessage Put(MovieModel movie)
        {
            var _result = iMovie.UpdateMovie(movie);
            return Request.CreateResponse(HttpStatusCode.OK, _result);
        }
        #endregion
    }
}
