using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class KierownikClass : CzlonekKadry
    {
        public KierownikClass(string imie)
        {
            this.Name = imie;
        }
        public override void specjalnoscPracownika(Stanowisko specjalnosc)
        {
            if (specjalnosc == Stanowisko.kierownik)
                Console.WriteLine("Kierownik kieruje", Name, specjalnosc);
            else if (next != null)
                next.specjalnoscPracownika(specjalnosc);
        }
    }
}