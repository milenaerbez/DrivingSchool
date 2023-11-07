using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class KreirajKandidataSO : BaseSO
    {
        Kandidat k;

        public KreirajKandidataSO(Kandidat k)
        {
            this.k = k; 
        }
        protected override void ExecuteOperation()
        {
           repository.Add(k);
        }
    }
}
