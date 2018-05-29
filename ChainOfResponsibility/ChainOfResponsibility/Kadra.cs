using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class CzlonekKadry
    {
        public string Name { get; set; }
        protected CzlonekKadry next;

        public void SetNext(CzlonekKadry CzlonekKadry)
        {
            next = CzlonekKadry;
        }

        public abstract void specjalnoscPracownika(Stanowisko specjalnosc); 
    }
}
