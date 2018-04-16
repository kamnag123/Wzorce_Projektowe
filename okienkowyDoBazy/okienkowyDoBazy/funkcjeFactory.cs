using System;
using System.Data;

namespace okienkowyDoBazy
{
    abstract class funkcjeFactory
    {
        public abstract DataTable pobieranieBaza();
        public abstract void dodajBaza(String user);
        public abstract void usunBaza(int number);
        public abstract DataTable sortuj();
    }
}
