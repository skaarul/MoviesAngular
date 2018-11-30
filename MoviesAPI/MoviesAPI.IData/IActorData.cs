using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.Model;

namespace MoviesAPI.IData
{
    public interface IActorData
    {
        List<ActorModel> GetActorsList();
        bool AddNewActor(ActorModel proinput);
    }
}
