using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace okienkowyDoBazy
{
    static class FunkcjeUniwersalne
    {
        private static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test;";
        private static MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public static DataTable WyswietlTabele(string tabelaWBazie, string doczepka)
        { 
            try
            {
                DataTable dt = new DataTable();
                string query = $"SELECT * FROM {tabelaWBazie} {doczepka};";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, databaseConnection);
                databaseConnection.Open();

                adapter.Fill(dt);

                databaseConnection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        
        public static void Dodawanie(string tabelaWBazie, string nazwaZmiennej, string nazwaDoDopisania)
        {
            string query = $"INSERT INTO {tabelaWBazie} ({nazwaZmiennej}) VALUES ('{nazwaDoDopisania}');";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteReader();
                MessageBox.Show("Udało się, normalnie cud!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Usuwanie(string tabelaWBazie, string nazwaZmiennej, int coOdjac)
        {
            string query = $"DELETE FROM {tabelaWBazie} WHERE {nazwaZmiennej} = {coOdjac};";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                commandDatabase.ExecuteReader();
                MessageBox.Show("Udało się, normalnie cud!");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
