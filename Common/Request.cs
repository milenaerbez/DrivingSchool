using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    public enum Operation
    {
        Prijava,
        DodajKandidata,
        SacuvajGrupu,
        VratiSveGrupe,
        PretraziKandidate,
        ObrisiKandidata,
        SacuvajTermine,
        ObrisiGrupu,
        UcitajTermineZaGrupu,
        UcitajKandidate,
        SacuvajPrisustva,
        UcivajSveKandidate,
        IzmenaGrupe,
        IzmenaKandidata,
        PretraziGrupe,
        VratiPrisustva
    }
    [Serializable]
    public class Request
    {
        public object RequestObj { get; set; }
        public Operation Operation { get; set; }

    }
}
