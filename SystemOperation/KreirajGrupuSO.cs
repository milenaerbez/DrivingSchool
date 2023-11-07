using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class KreirajGrupuSO : BaseSO
    {
        Grupa g;
        public KreirajGrupuSO(Grupa g)
        {
            this.g = g;
        }

        protected override void ExecuteOperation()
        {
           repository.Add(g);
            Console.WriteLine("Uspesno");

            //termini
            foreach(Termin t in g.Termini)
            {
                t.Grupa = g;
                repository.Add(t);
            }
        }
    }
}
