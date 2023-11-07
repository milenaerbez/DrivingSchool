using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class SacuvajTermineSO : BaseSO
    {
        private BindingList<Termin> requestObj;

        public SacuvajTermineSO(BindingList<Termin> requestObj)
        {
            this.requestObj = requestObj;
        }

        protected override void ExecuteOperation()
        {
            foreach(Termin t in requestObj)
            {
                repository.Add(t);
            }
        }
    }
}
