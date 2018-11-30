using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.IData;
using MoviesAPI.Model;

namespace MoviesAPI.Data
{
    public class ActorData :IActorData
    {
        #region Memeber(s)
        private ProjectXDataContext Db;
        #endregion
        #region Constructor(s)
        public ActorData()
        {
            Db = DataContextProvider.GetDataContext();
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// Get the actors list from database
        /// </summary>
        /// <returns></returns>
        public List<ActorModel> GetActorsList()
        {
            return Db.Actors.Select(s => new ActorModel { ActorId = s.ActorId, ActorName = s.ActorName, DOB = s.DateOfBirth, Gender = Convert.ToInt32(s.Gender) }).ToList();
        }
        /// <summary>
        /// Add new Actor
        /// </summary>
        /// <param name="proinput"></param>
        /// <returns></returns>
        public bool AddNewActor(ActorModel proinput)
        {
            Actor _actor = new Actor();
            _actor.ActorName = proinput.ActorName;
            _actor.DateOfBirth = proinput.DOB;
            _actor.Bio = proinput.Bio;
            _actor.Gender = Convert.ToBoolean(proinput.Gender);
            Db.Actors.InsertOnSubmit(_actor);
            Db.SubmitChanges();
            return true;
        }
        #endregion
    }
}
