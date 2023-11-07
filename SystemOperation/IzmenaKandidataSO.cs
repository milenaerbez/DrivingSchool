using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class IzmenaKandidataSO : BaseSO
    {
        private Kandidat k;

        public IzmenaKandidataSO(Kandidat requestObj)
        {
            this.k = requestObj;
        }

        protected override void ExecuteOperation()
        {
            repository.Update(k, $"Ime='{k.Ime}',Prezime='{k.Prezime}',DatumRodjenja='{k.DatumRodjenja}',BrLicneKarte='{k.BrojLicneKarte}',GrupaID={k.Grupa.ID}");
        }
    }
}
