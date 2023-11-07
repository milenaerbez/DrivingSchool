using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperation
{
    public class UcitajGrupeSO : BaseSO
    {
        public List<Grupa> Result { get; set; }

        protected override void ExecuteOperation()
        {
         Result=   repository.GetAll(new Grupa()).OfType<Grupa>().ToList();
        }
    }
}
