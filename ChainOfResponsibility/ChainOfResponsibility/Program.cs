using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CzlonekKadry cukiernik = new CukiernikClass("Bączkowski");
            CzlonekKadry piekarz = new PiekarzClass("Różyczkowski");
            CzlonekKadry kierownik = new KierownikClass("Pienicki");
            
            
            cukiernik.SetNext(piekarz);
            piekarz.SetNext(kierownik);

            List<Stanowisko> kadra = new List<Stanowisko>
            {
                Stanowisko.kierownik,
                Stanowisko.piekarz,
                Stanowisko.cukiernik
            };

            Console.WriteLine("Kadra pracownicza piekarni Różyczka\n");

            foreach (var specjalnosc in kadra)
                cukiernik.specjalnoscPracownika(specjalnosc);

            Console.ReadLine();
        }
    }
}
