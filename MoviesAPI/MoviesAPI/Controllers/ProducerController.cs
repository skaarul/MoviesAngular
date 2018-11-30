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
    public class ProducerController : ApiController
    {
        #region Member(s)
        private IProducer iProducer;
        #endregion
        #region Constructor(s)
        public ProducerController(IProducer _clsProducer)
        {
            iProducer = _clsProducer;
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// Get Producer list
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, iProducer.GetProducerList());
        }
        [HttpPost]
        public HttpResponseMessage Post(ProducerModel producerData)
        {
            return Request.CreateResponse(HttpStatusCode.OK, iProducer.AddNewProducer(producerData));
        }
        #endregion
    }
}
