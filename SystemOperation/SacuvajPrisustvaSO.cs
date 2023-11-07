using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class SacuvajPrisustvaSO : BaseSO
    {
        private BindingList<Prisustvo> prisustva;

        public SacuvajPrisustvaSO(BindingList<Prisustvo> requestObj)
        {
            prisustva = requestObj;
        }

        protected override void ExecuteOperation()
        {
            foreach(Prisustvo p in prisustva)
            {
                repository.Add(p);
            }
        }
    }
}
