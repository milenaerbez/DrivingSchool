using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperation;

namespace Server
{
    internal class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        private Controller()
        {
        }

        public object Prijava(Korisnik requestObj)
        {
            BaseSO so = new PrijavaSO(requestObj);
            so.Execute();
            return ((PrijavaSO)so).Result;
        }

        internal void KreirajGrupu(Grupa requestObj)
        {
            BaseSO so = new KreirajGrupuSO(requestObj);
            so.Execute();

            
        }

        internal object VratiSveGrupe()
        {
            BaseSO so = new UcitajGrupeSO();
            so.Execute();
            return ((UcitajGrupeSO)so).Result;
        }

        internal void KreirajKandidata(Kandidat requestObj)
        {
           BaseSO so=new KreirajKandidataSO(requestObj);
            so.Execute();

        }

       

        internal object PretraziKandidate(Kandidat requestObj, string criteria)
        {
            BaseSO so = new PretraziKandidateSO(requestObj, criteria);
            so.Execute();
            return ((PretraziKandidateSO)so).Result;

        }

        internal void ObrisiKandidata(Kandidat requestObj)
        {
            BaseSO so=new ObrisiKandidataSO(requestObj);
            so.Execute();
        }

        internal void SacuvajTermine(BindingList<Termin> requestObj)
        {
            BaseSO so = new SacuvajTermineSO(requestObj);
            so.Execute();
        }

        internal void ObrisiGrupu(Grupa requestObj)
        {
            BaseSO so = new ObrisiGrupuSO(requestObj);
            so.Execute();
        }

        internal object UcitajTermineZaGrupu(Termin t, string kriterijum)
        {
            BaseSO so = new UcitajTermineSO(t, kriterijum);
            so.Execute();
            return((UcitajTermineSO)so).Result;
        }

        internal object UcitajKandidate(Kandidat kandidat, string text)
        {
            BaseSO so = new PretraziKandidateSO(kandidat, text);
            so.Execute();
            return ((PretraziKandidateSO)so).Result;
    
        }

        internal void SacuvajPrisustva(BindingList<Prisustvo> requestObj)
        {
            BaseSO so = new SacuvajPrisustvaSO(requestObj);
            so.Execute();
        }

        internal object UcitajSveKandidate()
        {
            BaseSO so = new UcitajSveKandidateSO();
            so.Execute();
            return ((UcitajSveKandidateSO)so).Result;
        }

        internal void IzmeniGrupu(Grupa requestObj)
        {
            BaseSO so = new IzmenaGrupeSO(requestObj);
            so.Execute();
        }

        internal void IzmeniKandidata(Kandidat requestObj)
        {
            BaseSO so = new IzmenaKandidataSO(requestObj);
            so.Execute();
        }

        internal object PretraziGrupe(Grupa g, string krit)
        {
            BaseSO so = new PretraziGrupeSO(g, krit);
            so.Execute();
            return ((PretraziGrupeSO)so).Result;
        }

        internal object VratiPrisustva()
        {
            BaseSO so = new VratiPrisustvaSO();
            so.Execute();
            return ((VratiPrisustvaSO)so).Result;
        }
    }
}
