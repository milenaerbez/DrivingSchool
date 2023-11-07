using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class PrijavaSO : BaseSO
    {
        public Korisnik korisnik;
        public Korisnik Result { get; set; }

        public PrijavaSO(Korisnik korisnik)
        {
            this.korisnik = korisnik;   
        }

        protected override void ExecuteOperation()
        {
           List<Korisnik> korisnici=repository.GetAll(korisnik).OfType<Korisnik>().ToList();    

            foreach(Korisnik k in korisnici)
            {
                if(k.KorisnickoIme==korisnik.KorisnickoIme && k.Lozinka == korisnik.Lozinka)
                {
                    Result = k;
                    return;
                }
            }
            Result = null;

        }
    }
}
