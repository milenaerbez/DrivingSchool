using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class IzmenaGrupeSO : BaseSO
    {
        Grupa g;
       // private Grupa requestObj;

        public IzmenaGrupeSO(Grupa requestObj)
        {
            g = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Update(g,$"DatumPolaska='{g.DatumPocetka}'");
            if (g.Termini.Count > 0)
            {
                foreach (Termin t in g.Termini)
                {
                    t.Grupa = g;
                    repository.Add(t);
                }
            }
           
           
        }
    }
}
