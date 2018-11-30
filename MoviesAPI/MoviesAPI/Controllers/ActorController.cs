using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoviesAPI.Filters;
using MoviesAPI.IBusiness;
using MoviesAPI.Model;

namespace MoviesAPI.Controllers
{
    [APIExceptionFilter]
    public class ActorController : ApiController
    {
        #region Member(s)
        private IActor iActor;
        #endregion
        #region Constructor(s)
        public ActorController(IActor _clsActor)
        {
            iActor = _clsActor;
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// Get actors list
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, iActor.GetActorsList());
        }
        /// <summary>
        /// Add new actor
        /// </summary>
        /// <param name="inputdata"></param>
        /// <returns></returns>
        [HttpPost]
        public HttpResponseMessage Post(ActorModel inputdata)
        {
            return Request.CreateResponse(HttpStatusCode.OK, iActor.AddNewActor(inputdata));
        }
        #endregion
    }
}
