using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.Data;
using MoviesAPI.IBusiness;
using MoviesAPI.IData;
using MoviesAPI.Model;

namespace MoviesAPI.Business
{
    public class ProducerBusiness : IProducer
    {
        #region Memeber(s)
        private IProducerData producerData;
        #endregion
        #region Constructor(s)
        public ProducerBusiness()
        {
            producerData = new ProducerData();
        }
        #endregion
        #region Method(s)
        /// <summary>
        /// Get the producers list
        /// </summary>
        /// <returns></returns>
        public List<ProducerModel> GetProducerList()
        {
            return producerData.GetProducerList();
        }
        /// <summary>
        /// Add new producer
        /// </summary>
        /// <param name="proinput"></param>
        /// <returns></returns>
        public bool AddNewProducer(ProducerModel proinput)
        {
            return producerData.AddNewProducer(proinput);
        }
        #endregion
    }
}
