using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace MoviesAPI.Filters
{
    /// <summary>
    /// API exception filter
    /// </summary>
    public class APIExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// Exception logics
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            // Write required exception handling and log
            var _response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            _response.Content = new StringContent(actionExecutedContext.Exception.Message);
            actionExecutedContext.Response = _response;
        }
    }
}