using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okienkowyDoBazy
{
    class products: funkcjeFactory
    {
        private const string TABELA = "products";
        public override DataTable pobieranieBaza()
        {
            return FunkcjeUniwersalne.WyswietlTabele(TABELA, "");
        }

        public override void dodajBaza(string wpisUzytkownika)
        {
            FunkcjeUniwersalne.Dodawanie(TABELA, "nameproduct", wpisUzytkownika);
        }

        public override void usunBaza(int number)
        {
            FunkcjeUniwersalne.Usuwanie(TABELA, "Id_products", number);
        }

        public override DataTable sortuj()
        {
            string doczepka = $"ORDER BY {TABELA}.nameproduct ASC";
            return FunkcjeUniwersalne.WyswietlTabele(TABELA, doczepka);
        }        
    }
}
