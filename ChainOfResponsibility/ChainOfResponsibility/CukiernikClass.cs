using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class CukiernikClass : CzlonekKadry
    {
        public CukiernikClass(string imie)
        {
            this.Name = imie;
        }
        public override void specjalnoscPracownika(Stanowisko specjalnosc)
        {
            if (specjalnosc == Stanowisko.cukiernik)
                Console.WriteLine("Cukiernik piecze ciastka", Name, specjalnosc);
            else if (next != null)
                next.specjalnoscPracownika(specjalnosc);
        }
    }
}