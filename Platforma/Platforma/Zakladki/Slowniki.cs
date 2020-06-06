using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Platforma.PolaczenieZBazą;

namespace Platforma.Zakladki
{
    public partial class Slowniki : Form
    {
        public Slowniki()
        {
            InitializeComponent();
            uzupelnijComboboxZTypami();
            uzupelnijListeSlownikow();
        }

        private void uzupelnijListeSlownikow()
        {
            DataTable DataTable = SQLHelper.pobierListeSlownikow();
            foreach (DataRow row in DataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["typSlownika"].ToString());
                item.SubItems.Add(row["wartoscSlownika"].ToString().Trim()); 
                listSlowniki.Items.Add(item);
            }
        }

        private void uzupelnijComboboxZTypami()
        {
            cbTypSlownika.Items.Add("Linia");
            cbTypSlownika.Items.Add("Firma");
            cbTypSlownika.Items.Add("Inzynier");
        }
        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajWartoscDoSlownika_Click(object sender, EventArgs e)
        {
            string typ = cbTypSlownika.Text;
            string wartosc = TbWartoscSlownika.Text;

            bool wynik = SQLHelper.dodajWartoscSlownika(typ, wartosc);
            if(wynik)
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Green;
                labelInformacja.Text = "Dodano wpis";
                listSlowniki.Items.Clear();
                uzupelnijListeSlownikow();
                TbWartoscSlownika.Text = "";
            }
            else
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Błąd z dodaniem wpisu: " + e;
            }
        }

        private void btnUsunWartoscSlownika_Click(object sender, EventArgs e)
        {
            if (listSlowniki.SelectedItems.Count > 0)
            {
                string typ = listSlowniki.SelectedItems[0].SubItems[0].Text;
                string wartosc = listSlowniki.SelectedItems[0].SubItems[1].Text;

                bool wynik = SQLHelper.usunWartoscSlownika(typ, wartosc);
                if (wynik)
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Green;
                    labelInformacja.Text = "Usunięto wpis";
                    listSlowniki.Items.Clear();
                    uzupelnijListeSlownikow(); 
                }
                else
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Red;
                    labelInformacja.Text = "Błąd z usunięciem wpisu: " + e;
                }
            }
                

        }
    }
}
