using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TematskaJedinica
    {
        public static List<string> tematskeJedinice;

        static TematskaJedinica()
        {
            tematskeJedinice = new List<string>()
            {
                 "Bezbednost saobraćaja",
            "Učesnici u saobraćaju",
            "Vozačka dozvola",
            "Saobraćajni znakovi",
            "Pravila u saobracaju"
            };
        }

    }
}
