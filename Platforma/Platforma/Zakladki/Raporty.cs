using System.Diagnostics;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.Text;
using System;
using System.Linq;
using Platforma.PolaczenieZBazą;
using System.Data;

namespace Platforma.Zakladki
{
    public partial class Raporty : Form
    {
        public Raporty()
        {
            InitializeComponent();
            pobierzListeRaportow();
        }

        public void pobierzListeRaportow()
        {
            var dt = SQLHelper.pobierzListeRaportow();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["identyfikatorSortu"].ToString());
                item.SubItems.Add(row["numerCzesci"].ToString().Trim()); 
                item.SubItems.Add(row["dataUruchomienia"].ToString().Trim());
                item.SubItems.Add(row["dataZakonczenia"].ToString().Trim());
                item.SubItems.Add(row["inzynier"].ToString().Trim());
                item.SubItems.Add(row["wady"].ToString().Trim());
                item.SubItems.Add(row["norma"].ToString().Trim());
                item.SubItems.Add(row["kosztNormogodziny"].ToString().Trim());
                listaRaportow.Items.Add(item);
            }
        } 

        private void btnStworzRaport_Click(object sender, EventArgs e)
        {
            if (listaRaportow.SelectedItems.Count > 0)
            {
                string filename = "testDokumentu.docx";
                var dzisiejszaData = DateTime.Today;
                string numerCzesci = listaRaportow.SelectedItems[0].SubItems[1].Text;
                string identyfikatorSortu = listaRaportow.SelectedItems[0].SubItems[0].Text;
                string inzynier = listaRaportow.SelectedItems[0].SubItems[4].Text;
                string dataRozpoczeciaSortu = listaRaportow.SelectedItems[0].SubItems[2].Text;
                string wady = listaRaportow.SelectedItems[0].SubItems[5].Text; 

                var doc = DocX.Create(filename);

                string prawaStrona = $"Data:  {dzisiejszaData.ToString("dd-MM-yyyy")}" + Environment.NewLine +
                                     "Miejsce sortowania: Wabco";

                string lewaStrona = $"Identyfikator sortowania: {identyfikatorSortu}" + Environment.NewLine +
                                        $"Numer części: {numerCzesci}" + Environment.NewLine + 
                                        $"Sortowanie zostało zlecone przez: " + Environment.NewLine +
                                        $"{inzynier} dnia {dataRozpoczeciaSortu}" + Environment.NewLine +
                                        $"Zgłoszone wady:" + Environment.NewLine +
                                        wady + Environment.NewLine;

                Paragraph par1 = doc.InsertParagraph(prawaStrona);
                par1.Alignment = Alignment.right;
                par1.FontSize(12d);
                par1.Font("Arial");
                par1.Position(5);

                Paragraph par = doc.InsertParagraph(lewaStrona);
                par.Alignment = Alignment.left;
                par.FontSize(11d);
                par.Font("Arial");
                par.Position(5);

                string srodek = "Przebieg sortowania: ";

                Paragraph naglowek = doc.InsertParagraph(srodek);
                naglowek.Alignment = Alignment.center;
                naglowek.FontSize(26d);
                naglowek.Font("Arial");
                naglowek.Position(50);

                var dt = SQLHelper.pobierzListeWpisow(identyfikatorSortu, numerCzesci); 

                Table t = doc.AddTable(dt.Rows.Count+1, 4);
                //t.Design = TableDesign.TableNormal; 
                t.Design = TableDesign.TableGrid;


                t.Rows[0].Cells[0].Paragraphs.First().Append("Data").Alignment = Alignment.center;
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ilość sprawdzonych sztuk").Alignment = Alignment.center;
                t.Rows[0].Cells[2].Paragraphs.First().Append("Ilość dobrych sztuk").Alignment = Alignment.center;
                t.Rows[0].Cells[3].Paragraphs.First().Append("Ilość złych sztuk").Alignment = Alignment.center;

                for (int i = 0, j = 1; i < dt.Rows.Count; i++,j++)
                {
                    t.Rows[j].Cells[0].Paragraphs.First().Append(dt.Rows[i][2].ToString()).Alignment = Alignment.center;
                    t.Rows[j].Cells[1].Paragraphs.First().Append(dt.Rows[i][4].ToString()).Alignment = Alignment.center;
                    t.Rows[j].Cells[2].Paragraphs.First().Append(dt.Rows[i][5].ToString()).Alignment = Alignment.center;
                    t.Rows[j].Cells[3].Paragraphs.First().Append(dt.Rows[i][6].ToString()).Alignment = Alignment.center;
                }
                doc.InsertTable(t);

                var iloscWszystkichCzesci = SQLHelper.sumaWszystkichCzesci(identyfikatorSortu, numerCzesci);
                var iloscDobrychSztuk = SQLHelper.sumaWszystkichDobrychCzesci(identyfikatorSortu, numerCzesci);
                var iloscZlychSztuk = SQLHelper.sumaWszystkichWadliwychCzesci(identyfikatorSortu, numerCzesci);


                string statystyki = Environment.NewLine + "Statystyki sortowania" + Environment.NewLine +
                                    $"Suma przesortowanych części: {iloscWszystkichCzesci.Rows[0][0]}" + Environment.NewLine +
                                    $"Ilość dobrych sztuk: {iloscDobrychSztuk.Rows[0][0]}" + Environment.NewLine +
                                    $"Ilość wadliwych sztuk: {iloscZlychSztuk.Rows[0][0]}";

                Paragraph stats = doc.InsertParagraph(statystyki);
                stats.Alignment = Alignment.right;
                stats.FontSize(11d);
                stats.Font("Arial");
                stats.Position(4);

                double normogodzina = Convert.ToDouble(listaRaportow.SelectedItems[0].SubItems[6].Text.Trim());
                double kosztNormogodziny = Convert.ToDouble(listaRaportow.SelectedItems[0].SubItems[7].Text.Trim());
                double liczbaNormogodzin = Convert.ToDouble(iloscWszystkichCzesci.Rows[0][0]) / normogodzina;
                double cena = liczbaNormogodzin * kosztNormogodziny;
                string kosztSortu = "Norma godzinowa: " + normogodzina + Environment.NewLine +
                                  $"Cena normogodziny: " + kosztNormogodziny + Environment.NewLine +
                                  $"Koszt sortowania: " + Math.Round(cena,2);

                Paragraph kosztObslugi = doc.InsertParagraph(kosztSortu);
                kosztObslugi.Alignment = Alignment.left;
                kosztObslugi.FontSize(11d);
                kosztObslugi.Font("Arial");
                kosztObslugi.Position(4);

                string podpis = Environment.NewLine + "........................" + Environment.NewLine +
                                "Podpis inżyniera";

                Paragraph pod = doc.InsertParagraph(podpis);
                pod.Alignment = Alignment.right;
                pod.FontSize(12d);
                pod.Font("Arial");
                pod.Position(4);

                doc.Save();
                Process.Start("WINWORD.exe", filename);
            }
        }

        private void btnAktualizujKosztSortowania_Click(object sender, EventArgs e)
        {
            if (listaRaportow.SelectedItems.Count > 0)
            {
                if(tbNormogodzina.Text != "" || tbKosztNormogodziny.Text != "")
                {
                    string identyfikator = listaRaportow.SelectedItems[0].SubItems[0].Text.Trim();

                    bool pusto = false;
                    if (listaRaportow.SelectedItems[0].SubItems[6].Text.Trim() == "" || listaRaportow.SelectedItems[0].SubItems[7].Text.Trim() == "")
                    {
                        pusto = true;
                    }
                    
                    if (pusto)
                    {
                        SQLHelper.aktualizujDaneKosztuSortowania(tbNormogodzina.Text, tbKosztNormogodziny.Text, identyfikator, true);
                        listaRaportow.Items.Clear();
                        pobierzListeRaportow();
                    }
                    else
                    {
                        SQLHelper.aktualizujDaneKosztuSortowania(tbNormogodzina.Text, tbKosztNormogodziny.Text, identyfikator, false);
                        listaRaportow.Items.Clear();
                        pobierzListeRaportow();
                    }
                } 
            } 
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
