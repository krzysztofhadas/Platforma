using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Platforma.PolaczenieZBazą;

namespace Platforma.Zakladki
{
    public partial class EdytujSort : Form
    {
        private string numerCzesci;
        private string aktualnaWada;
        private string prefiks;
        private string status;
        public EdytujSort(string numerCzesci, string wada, string prefiks, string status)
        {
            InitializeComponent();
            this.numerCzesci = numerCzesci;
            this.aktualnaWada = wada;
            this.prefiks = prefiks;
            this.status = status;

            labelEdytowanySort.Text = "Informacje na temat sortu częsci nr: " + numerCzesci;
            tbWadaCzesci.Text = wada;
            pobierzListeWpsiow();
            if (status == "Nie")
            {
                btnZakonczSort.Text = "Zakończ sort";
            }
            else
            {
                btnZakonczSort.Text = "Aktywuj sort";
            }
        }

        private void btnAktualizujWade_Click(object sender, EventArgs e)
        {
            string nowaWada = tbWadaCzesci.Text;
            bool wykonane = SQLHelper.aktualizujWadeSortu(aktualnaWada, numerCzesci, nowaWada);
            if (wykonane)
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Green;
                labelInformacja.Text = "Wada została zmieniona";
            }
            else
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Błąd przy próbie zmiany wady";
            }
        }

        public void pobierzListeWpsiow()
        {
            listWpisowSortu.Items.Clear();
            DataTable DataTable = SQLHelper.pobierzListeWpisow(prefiks, numerCzesci);

            foreach (DataRow row in DataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["data"].ToString());
                item.SubItems.Add(row["iloscSprawdzonych"].ToString());
                item.SubItems.Add(row["iloscOk"].ToString());
                item.SubItems.Add(row["IloscNok"].ToString());
                listWpisowSortu.Items.Add(item);
            }
        }

        private bool sprawdzIlosc(int wszystkie, int dobre, int zle)
        {
            int temp = dobre + zle;
            if(wszystkie == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnDodajWpis_Click(object sender, EventArgs e)
        {
            string data = tbData.Text;
            int iloscWszystkich = Convert.ToInt32(tbIloscWszystkich.Text);
            int iloscOk = Convert.ToInt32(tbIloscOK.Text);
            int iloscNok = Convert.ToInt32(tbIloscNOK.Text);
            if(sprawdzIlosc(iloscWszystkich, iloscOk, iloscNok))
            {
                bool wykonane = SQLHelper.dodajWpisDoSortu(prefiks, data, numerCzesci, iloscWszystkich, iloscOk, iloscNok);
                if (wykonane)
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Green;
                    labelInformacja.Text = "Wpis został dodany";
                    pobierzListeWpsiow();
                }
                else
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Red;
                    labelInformacja.Text = "Błąd przy próbie dodania wpisu";
                }
            }
            else
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Ilości Ok i Nok się nie sumują";
            }
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsunInformacje_Click(object sender, EventArgs e)
        {
            if (listWpisowSortu.SelectedItems.Count > 0)
            {
                string data = listWpisowSortu.SelectedItems[0].SubItems[0].Text; 
                bool wykonane = SQLHelper.usunWpis(prefiks, data); 
                if (wykonane)
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Green;
                    labelInformacja.Text = "Wpis został dodany";
                    listWpisowSortu.Items.Clear();
                    pobierzListeWpsiow(); 
                }
                else
                {
                    labelInformacja.Visible = true;
                    labelInformacja.ForeColor = System.Drawing.Color.Red;
                    labelInformacja.Text = "Błąd przy próbie dodania wpisu";
                } 
            }
        }

        private void btnZakonczSort_Click(object sender, EventArgs e)
        {
            bool wykonane = SQLHelper.zakonczSort(prefiks, numerCzesci);
            if (wykonane)
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Green;
                labelInformacja.Text = "Sort został zakończony, zamykanie okna"; 
            }
            else
            {
                labelInformacja.Visible = true;
                labelInformacja.ForeColor = System.Drawing.Color.Red;
                labelInformacja.Text = "Błąd przy próbie zamkniecia sortu";
            } 
            this.Close();
        }
    }
}
