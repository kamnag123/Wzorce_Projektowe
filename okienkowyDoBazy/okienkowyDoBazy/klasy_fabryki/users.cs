using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okienkowyDoBazy
{
    class users : funkcjeFactory
    {
        private const string TABELA = "users";

        public override DataTable pobieranieBaza()
        {
            return FunkcjeUniwersalne.WyswietlTabele(TABELA, "");
        }

        public override void dodajBaza(string wpisUzytkownika)
        {
            FunkcjeUniwersalne.Dodawanie(TABELA, "name", wpisUzytkownika);
        }

        public override void usunBaza(int number)
        {
            FunkcjeUniwersalne.Usuwanie(TABELA, "Id_user", number);
        }

        public override DataTable sortuj()
        {
            string doczepka = $"ORDER BY {TABELA}.name ASC";
            return FunkcjeUniwersalne.WyswietlTabele(TABELA, doczepka);
        }
    }
}
