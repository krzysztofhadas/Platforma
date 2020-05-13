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
using Platforma.Zakladki;

namespace Platforma
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            pobierzListeSortow("Tak");
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRaporty_Click(object sender, EventArgs e)
        {

        }

        private void btnZakonczoneSorty_Click(object sender, EventArgs e)
        {
            pobierzListeSortow("Nie");
        }

        private void btnUsunSort_Click(object sender, EventArgs e)
        {
            if (listaAktywnychSortow.SelectedItems.Count > 0)
            { 
                string prefiks = listaAktywnychSortow.SelectedItems[0].SubItems[0].Text;
                SQLHelper.usunSort(prefiks);
                pobierzListeSortow("Tak");
            }
        }

        private void btnEdytujSort_Click(object sender, EventArgs e)
        {
            if(listaAktywnychSortow.SelectedItems.Count > 0)
            {
                string numerCzesci = listaAktywnychSortow.SelectedItems[0].SubItems[1].Text;
                string wada = listaAktywnychSortow.SelectedItems[0].SubItems[6].Text;
                string prefiks = listaAktywnychSortow.SelectedItems[0].SubItems[0].Text;
                string status = listaAktywnychSortow.SelectedItems[0].SubItems[7].Text;

                EdytujSort edytujSort = new EdytujSort(numerCzesci, wada, prefiks, status);
                edytujSort.Show();
            } 
        }

        private void btnDodajSort_Click(object sender, EventArgs e)
        {
            NowySort NowySort = new NowySort();
            NowySort.Show(); 
        }

        private void btnListaAktywnychSortów_Click(object sender, EventArgs e)
        {
            pobierzListeSortow("Tak");
        } 
        private void pobierzListeSortow(string status)
        {
            listaAktywnychSortow.Items.Clear();
            var dt = SQLHelper.pobierzListeSortow(status);
            
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["prefix"].ToString());
                item.SubItems.Add(row["numerCzesci"].ToString());
                item.SubItems.Add(row["linia"].ToString());
                item.SubItems.Add(row["dataUruchomienia"].ToString());
                item.SubItems.Add(row["firmaDostawca"].ToString());
                item.SubItems.Add(row["inzynier"].ToString());
                item.SubItems.Add(row["opisProblemu"].ToString());
                item.SubItems.Add((row["status"].ToString()));
                listaAktywnychSortow.Items.Add(item);
            }
            
        }
    }
}
