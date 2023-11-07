using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Kategorija
    {
        public static List<string> kategorije;
        static Kategorija()
        {
            kategorije = new List<string>()
            {
                "A","A1","B","BE"
            };
        }

    }
}
