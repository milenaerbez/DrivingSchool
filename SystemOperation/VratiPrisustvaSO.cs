using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class VratiPrisustvaSO : BaseSO
    {
        public List<Prisustvo> Result { get; set; }

        protected override void ExecuteOperation()
        {
            Result = repository.GetAll(new Prisustvo()).OfType<Prisustvo>().ToList();
          
        }
    }
}
