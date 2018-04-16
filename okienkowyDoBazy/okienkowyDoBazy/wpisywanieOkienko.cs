using System;
using System.Windows.Forms;

namespace okienkowyDoBazy
{
    public partial class wpisywanieOkienko : Form
    {
        public string Nazwa { get; set; }

        public wpisywanieOkienko()
        {
            InitializeComponent();
        }

        private void nie_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void tak_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Nie podałeś wszystkich wymaganych danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Nazwa = textBox1.Text;
            Close();
        }
    }
}
