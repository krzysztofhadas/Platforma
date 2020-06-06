using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Platforma;
using Platforma.PolaczenieZBazą;

namespace Platforma.OknoLogowania
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
            tbHaslo.PasswordChar = '*';
        }

        private void btnLogowanie_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string haslo = tbHaslo.Text;

            bool wynik = SQLHelper.logujUzytkownika(login, haslo);
            if (wynik)
            {
                Menu menu = new Menu(login);
                menu.Show();
                this.Hide(); 
            }
            else
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Niepoprawne dane logowania";
            }
        }
    }
}
