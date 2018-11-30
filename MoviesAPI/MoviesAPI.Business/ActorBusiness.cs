using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.IBusiness;
using MoviesAPI.Model;
using MoviesAPI.IData;
using MoviesAPI.Data;

namespace MoviesAPI.Business
{
    public class ActorBusiness: IActor
    {
        #region Memeber(s)
        private IActorData actorData;
        #endregion
        #region Constructor(s)
        public ActorBusiness()
        {
            actorData = new ActorData();
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// Get all the actors list
        /// </summary>
        /// <returns></returns>
        public List<ActorModel> GetActorsList() {
           return actorData.GetActorsList();
        }
        public bool AddNewActor(ActorModel proinput)
        {
            return actorData.AddNewActor(proinput);
        }
        #endregion
    }
}
