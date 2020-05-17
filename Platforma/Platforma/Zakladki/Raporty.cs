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
                listaRaportow.Items.Add(item);
            }
        }

        public void test()
        {
             /*  
              
            for (int i = 0; i < numerWierszy-1; i++)
            {
                 
                    Console.WriteLine(i);
                    t.Rows[(i+1)].Cells[0].Paragraphs.First().Append(tablica[i, 0]);
                    t.Rows[(i+1)].Cells[1].Paragraphs.First().Append(tablica[i, 1]);
                    t.Rows[(i+1)].Cells[2].Paragraphs.First().Append(tablica[i, 2]);
                    t.Rows[(i + 1)].Cells[3].Paragraphs.First().Append(tablica[i, 3]);
                
            }
            doc.InsertTable(t);


            doc.Save();
            Process.Start("WINWORD.exe", filename);

            */
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
                                        $"Numer sortowanych części: {numerCzesci}" + Environment.NewLine + 
                                        $"Sortowanie zostało zlecone przez: " + Environment.NewLine +
                                        $"{inzynier} dnia {dataRozpoczeciaSortu}" + Environment.NewLine +
                                        $"Wady zgłoszone przez osobę zlecającą:" + Environment.NewLine +
                                        wady + Environment.NewLine;

                Paragraph par1 = doc.InsertParagraph(prawaStrona);
                par1.Alignment = Alignment.right;
                par1.FontSize(12d);
                par1.Font("Arial");
                par1.Position(5);

                Paragraph par = doc.InsertParagraph(lewaStrona);
                par.Alignment = Alignment.left;
                par.FontSize(12d);
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
                t.Design = TableDesign.TableNormal;
                t.Alignment = Alignment.center;
                

                t.Rows[0].Cells[0].Paragraphs.First().Append("Data");
                t.Rows[0].Cells[1].Paragraphs.First().Append("Ilość sprawdzonych sztuk");
                t.Rows[0].Cells[2].Paragraphs.First().Append("Ilość dobrych sztuk");
                t.Rows[0].Cells[3].Paragraphs.First().Append("Ilość złych sztuk");

                for (int i = 0, j = 1; i < dt.Rows.Count; i++,j++)
                {
                    t.Rows[j].Cells[0].Paragraphs.First().Append(dt.Rows[i][2].ToString());
                    t.Rows[j].Cells[1].Paragraphs.First().Append(dt.Rows[i][4].ToString());
                    t.Rows[j].Cells[2].Paragraphs.First().Append(dt.Rows[i][5].ToString());
                    t.Rows[j].Cells[3].Paragraphs.First().Append(dt.Rows[i][6].ToString());
                }
                doc.InsertTable(t);

                var iloscWszystkichCzesci = SQLHelper.sumaWszystkichCzesci(identyfikatorSortu, numerCzesci);
                var iloscDobrychSztuk = SQLHelper.sumaWszystkichDobrychCzesci(identyfikatorSortu, numerCzesci);
                var iloscZlychSztuk = SQLHelper.sumaWszystkichWadliwychCzesci(identyfikatorSortu, numerCzesci);


                string statystyki = Environment.NewLine + "Statystyki sortowania: " + Environment.NewLine +
                                    $"Suma przesortowanych części: {iloscWszystkichCzesci.Rows[0][0]}" + Environment.NewLine +
                                    $"Ilość dobrych sztuk: {iloscDobrychSztuk.Rows[0][0]}" + Environment.NewLine +
                                    $"Ilość wadliwych sztuk: {iloscZlychSztuk.Rows[0][0]}";

                Paragraph stats = doc.InsertParagraph(statystyki);
                stats.Alignment = Alignment.left;
                stats.FontSize(12d);
                stats.Font("Arial");
                stats.Position(4);

                string podpis = Environment.NewLine + "........................" + Environment.NewLine +
                                "Podpis inżyniera";

                Paragraph pod = doc.InsertParagraph(podpis);
                pod.Alignment = Alignment.left;
                pod.FontSize(12d);
                pod.Font("Arial");
                pod.Position(4);

                doc.Save();
                Process.Start("WINWORD.exe", filename);
            }
        }
    }
}
