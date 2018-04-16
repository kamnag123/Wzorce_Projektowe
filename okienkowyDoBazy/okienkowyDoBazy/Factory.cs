using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okienkowyDoBazy
{
    class Factory
    {
        public static funkcjeFactory getObject(string className)
        {
            if (className.Equals("Użytkownicy"))
                return new users();

            if (className.Equals("Przedmioty"))
                return new products();

            return new priviledges();
        }
    }
}
