using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Training2.Data
{
    public class CarsModel
    {
        public bool Off { get; set; }
        public string Auto { get; set; }
        public string Typ { get; set; }

        public List<Cars> AutoListe { get; set; }
        public CarsModel()
        {
            AutoListe = new List<Cars>();
            AutoListe.Add(new Cars()
            {
                Hersteller = "BMW",
                Type = new Type[]{ new Type("X1"), new Type("X2"), new Type("M3"), new Type("I3") }
            });
            AutoListe.Add(new Cars()
            {
                Hersteller = "VW",
                Type = new Type[] { new Type("Golf"), new Type("Polo"), new Type("Beatle"), new Type("Touran"), new Type("T5") }
            });
            AutoListe.Add(new Cars()
            {
                Hersteller = "Chevrolet",
                Type = new Type[] { new Type("Camaro"), new Type("Captiva"), new Type("Cruze"), new Type("Volt") }
            });


        }
    }
}
