using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class ObrisiGrupuSO : BaseSO
    {
        private Grupa grupa;

        public ObrisiGrupuSO(Grupa grupa)
        {
            this.grupa = grupa;
        }

        protected override void ExecuteOperation()
        {
            repository.Delete(grupa);
        }
    }
}
