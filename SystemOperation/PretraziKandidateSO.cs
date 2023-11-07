using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class PretraziKandidateSO : BaseSO
    {
        private string text;
        Kandidat k;

        public PretraziKandidateSO(Kandidat k, string criteria)
        {
            this.k = k;
            text = criteria;
        }

        public List<Domain.Kandidat> Result { get; set; }
        protected override void ExecuteOperation()
        {
            Result = repository.Search(k, text).OfType<Kandidat>().ToList();
           
        }
    }
}
