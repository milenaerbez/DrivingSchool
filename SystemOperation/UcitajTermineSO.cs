using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajTermineSO : BaseSO
    {
        private Termin t;
        private string kriterijum;
        public List<Termin> Result { get; set; }

        public UcitajTermineSO(Termin t, string kriterijum)
        {
            this.t = t;
            this.kriterijum = kriterijum;
        }

        protected override void ExecuteOperation()
        {
            Result=repository.Search(t, kriterijum).OfType<Termin>().ToList();
        }
    }
}
