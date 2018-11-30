using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.Model;

namespace MoviesAPI.IBusiness
{
    public interface IActor
    {
        List<ActorModel> GetActorsList();
        bool AddNewActor(ActorModel proinput);
    }
}
