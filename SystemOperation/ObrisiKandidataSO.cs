using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class ObrisiKandidataSO : BaseSO
    {
        private Kandidat requestObj;

        public ObrisiKandidataSO(Kandidat requestObj)
        {
            this.requestObj = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Delete(requestObj);
        }
    }
}
