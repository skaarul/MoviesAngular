using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MoviesAPI.Model;

namespace MoviesAPI.Data
{
    /// <summary>
    /// DB context provider
    /// </summary>
    static class DataContextProvider
    {
        #region Method(s)
        /// <summary>
        /// Get the DB context
        /// </summary>
        /// <returns></returns>
        public static ProjectXDataContext GetDataContext()
        {
            if (HttpContext.Current != null)
            {
                if (HttpContext.Current.Items["DataContext"] != null)
                {
                    return (ProjectXDataContext)HttpContext.Current.Items["DataContext"];
                }
                else
                {
                    HttpContext.Current.Items["DataContext"] = new ProjectXDataContext(ConfigurationManager.AppSettings["DSN"]);
                    return (ProjectXDataContext)HttpContext.Current.Items["DataContext"];
                }
            }
            else
            {
                if (CallContext.GetData("DataContext") == null)
                {
                    CallContext.SetData("DataContext", new ProjectXDataContext(ConfigurationManager.AppSettings["DSN"]));
                }

                return (ProjectXDataContext)CallContext.GetData("DataContext");
            }
        }
        #endregion
    }
}
