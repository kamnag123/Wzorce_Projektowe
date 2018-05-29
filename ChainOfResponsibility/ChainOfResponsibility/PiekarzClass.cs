using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class PiekarzClass : CzlonekKadry
    {
        public PiekarzClass(string imie)
        {
            this.Name = imie;
        }
        public override void specjalnoscPracownika(Stanowisko specjalnosc)
        {
            if (specjalnosc == Stanowisko.piekarz)
                Console.WriteLine("Piekarz, piecze chleb", Name, specjalnosc);
            else if (next != null)
                next.specjalnoscPracownika(specjalnosc);
        }
    }
}