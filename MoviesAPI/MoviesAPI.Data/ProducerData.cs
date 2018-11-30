using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesAPI.IData;
using MoviesAPI.Model;

namespace MoviesAPI.Data
{
    public class ProducerData: IProducerData
    {
        #region Memeber(s)
        private ProjectXDataContext Db;
        #endregion
        #region Constructor(s)
        public ProducerData()
        {
            Db = DataContextProvider.GetDataContext();
        }
        #endregion
        /// <summary>
        /// Get Producers list
        /// </summary>
        /// <returns></returns>
        public List<ProducerModel> GetProducerList()
        {
           return Db.Producers.Select(p => new ProducerModel { ProducerId = p.ProducerID, ProducerName = p.ProducerName, Gender = Convert.ToInt32(p.Gender), DOB = p.DateOfBirth }).ToList();
        }
        public bool AddNewProducer(ProducerModel proinput)
        {
            Producer _producer = new Producer();
            _producer.ProducerName = proinput.ProducerName;
            _producer.DateOfBirth = proinput.DOB;
            _producer.Bio = proinput.Bio;
            _producer.Gender = Convert.ToBoolean(proinput.Gender);
            Db.Producers.InsertOnSubmit(_producer);
            Db.SubmitChanges();
            return true;
        }
    }
}
