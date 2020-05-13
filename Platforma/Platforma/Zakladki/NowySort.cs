using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Platforma.Zakladki;

namespace Platforma.Zakladki
{
    public partial class NowySort : Form
    {
        public NowySort()
        {
            InitializeComponent();
        }

        private void labelInformacja_Click(object sender, EventArgs e)
        {
            labelInformacja.Visible = false;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private bool sprawdzZawartoscTextBox(string prefiks, string numer, string linia, string data, string opis, string inzynier, string firma)
        {
            if (prefiks.Length == 0 || numer.Length == 0 || linia.Length == 0 || data.Length == 0 || opis.Length == 0 || inzynier.Length == 0 || firma.Length == 0)
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Wypełnij" + Environment.NewLine + "puste pola";
                return false;
            }
            else return true;
        }

        private void btnDodajSort_Click(object sender, EventArgs e)
        {

            string numer = tbNumerCzesci.Text.Trim();
            string linia = tbLinia.Text.Trim();
            string data = tbDataUruchomienia.Text.Trim();
            string opis = tbOpis.Text.Trim();
            string inzynier = tbInzynier.Text.Trim();
            string firma = tbDostawcaCzesci.Text.Trim();
            string prefiks = tbPrefix.Text.Trim();

            if (sprawdzZawartoscTextBox(prefiks, numer, linia, data, opis, inzynier, firma) == true)
            { 
                try
                {
                    PolaczenieZBazą.SQLHelper.dodajSort(prefiks, numer, linia, data, opis, inzynier, firma);
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Green;
                    labelInformacja.Text = "Dodano sort";
                }
                catch
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Red;
                    labelInformacja.Text = "Błąd z dodaniem sortu: " +e;
                }
            } 
        }
    }
}
