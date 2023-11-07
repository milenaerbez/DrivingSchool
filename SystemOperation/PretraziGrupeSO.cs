using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class PretraziGrupeSO : BaseSO
    {
        private Grupa g;
        private string krit;
       public List<Grupa> Result { get; set; }
        public PretraziGrupeSO(Grupa g, string krit)
        {
            this.g = g;
            this.krit = krit;
        }

        protected override void ExecuteOperation()
        {
            Result = repository.Search(g, krit).OfType<Grupa>().ToList();
        }
    }
}
