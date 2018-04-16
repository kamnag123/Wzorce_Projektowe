using System;
using System.Data;
using System.Windows.Forms;

namespace okienkowyDoBazy
{
    public partial class Form1 : Form
    {
        private funkcjeFactory obiekt;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            wpisywanieOkienko dialog = new wpisywanieOkienko();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                obiekt.dodajBaza(dialog.Nazwa);
            }
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (tabela.Rows.Count == 0 || tabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nie ma co usuwać, odczep się!");
                return;
            }

            int doUsuniecia = tabela.SelectedRows[0].Index;
            int id = int.Parse(tabela.Rows[doUsuniecia].Cells[0].Value.ToString());
            obiekt.usunBaza(id);
        }

        private void sortuj_Click(object sender, EventArgs e)
        {
            DataTable dt = obiekt.sortuj();
            tabela.DataSource = dt;
            tabela.Refresh();
        }

        private void pobierz_Click(object sender, EventArgs e)
        {
            DataTable dt = obiekt.pobieranieBaza();
            tabela.DataSource = dt;
            tabela.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            obiekt = Factory.getObject(comboBox1.Text);
        }
    }
}
