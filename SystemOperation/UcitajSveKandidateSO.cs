using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajSveKandidateSO : BaseSO
    {
        public List<Kandidat> Result { get; set; }
        protected override void ExecuteOperation()
        {
           Result=repository.GetAll(new Kandidat()).OfType<Kandidat>().ToList();
        }
    }
}
