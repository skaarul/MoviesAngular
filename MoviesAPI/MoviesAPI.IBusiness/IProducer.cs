using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.Model;

namespace MoviesAPI.IBusiness
{
    public interface IProducer
    {
        List<ProducerModel> GetProducerList();
        bool AddNewProducer(ProducerModel proinput);
    }
}
