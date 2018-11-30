using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Model
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int ReleaseYear { get; set; }
        public string Plot { get; set; }
        public Nullable<int> ProducerId { get; set; }
        public List<ActorModel> Actors { get; set; }
        public string ProducerName { get; set; }
        public List<int> ActorsArray { get; set; }
    }
    public class ActorModel
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public DateTime? DOB { get; set; }
        public int? Gender { get; set; }
        public string Bio { get; set; }
    }
    public class ProducerModel
    {
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public DateTime? DOB { get; set; }
        public int? Gender { get; set; }
        public string Bio { get; set; }
    }
}
