using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okienkowyDoBazy
{
    class priviledges : funkcjeFactory
    {
        private const string TABELA = "priviledges";

        public override DataTable pobieranieBaza() 
        {
            return FunkcjeUniwersalne.WyswietlTabele(TABELA, "");
        }

        public override void dodajBaza(string wpisUzytkownika)
        {
            FunkcjeUniwersalne.Dodawanie(TABELA, "name_priviledge", wpisUzytkownika);
        }

        public override void usunBaza(int number)
        {
            FunkcjeUniwersalne.Usuwanie(TABELA, "Id_priviledge", number);
        }

        public override DataTable sortuj()
        {
            string doczepka = $"ORDER BY {TABELA}.name_priviledge ASC";
            return FunkcjeUniwersalne.WyswietlTabele(TABELA, doczepka);
        }
    }
}
