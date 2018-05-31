using System;

namespace Proxy
{

    interface InterfejsKlas
    {
        void WypiszImionaUczniow();
    }

    class Klasa1A : InterfejsKlas
    {
        public void WypiszImionaUczniow()
        {
            Console.WriteLine("Kasia\nMarysia\nAntek ");
        }
    }
    class Klasa1B : InterfejsKlas
    {
        public void WypiszImionaUczniow()
        {
            Console.WriteLine("Wojtek\nPaweł\nJulka");
        }
    }

    class Proxy : InterfejsKlas
    {
       
        private InterfejsKlas klasa;
        private string haslo { get; set; }

        public Proxy(string haslo)
        {
            this.haslo = haslo;
        }

        private void TworzKlase(int ktoraKlasa)
        {
            if (ktoraKlasa == 1)
            {
                klasa = new Klasa1A();

            }
            if (ktoraKlasa == 2)
            {
                klasa = new Klasa1B();

            }
      
        }

        public void WypiszImionaUczniow()
        {
            if (haslo == "nauczyciel1")
            {
                TworzKlase(1);
                klasa.WypiszImionaUczniow();
            }
            if (haslo == "nauczyciel2")
            {
                TworzKlase(2);
                klasa.WypiszImionaUczniow();
            }
            else
            {
                Console.WriteLine("Wrong haslo");
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj hasło.");
            string haslo = Console.ReadLine();

            Proxy proxy = new Proxy(haslo);
            proxy.WypiszImionaUczniow();
            Console.ReadKey();
        }
    }
}
