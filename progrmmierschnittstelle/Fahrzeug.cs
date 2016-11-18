using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmierschnittstelle
{
    public class Fahrzeug
    {
        public string Farbe { get; set; }
        public int PS { get; set; }
        public int GefahreneKilometer { get; set; }
        public string Kennzeichen { get; set; }

        public static void Fahren()
        {
        }
        public static List<Fahrzeug> liste = new List<Fahrzeug>();
        
    }
}

