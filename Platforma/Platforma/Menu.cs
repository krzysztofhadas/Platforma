﻿using System;
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
        private string aktywnyUzytkownik;
        public Menu(string login)
        {
            InitializeComponent();
            pobierzListeSortow("Tak");
            aktywnyUzytkownik = login;
            sprawdzRoleOperatora();
        }
        
        private void sprawdzRoleOperatora()
        {
            bool wynik = SQLHelper.sprawdzUprawnieniaAdministratora(aktywnyUzytkownik);
            if (wynik)
            {
                btnSlowniki.Show();
            }
            else
            {
                btnSlowniki.Hide();
            }
        }
        private void btnZamknij_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnRaporty_Click(object sender, EventArgs e)
        {
            Raporty Raporty = new Raporty();
            Raporty.Show();
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
                string data = listaAktywnychSortow.SelectedItems[0].SubItems[3].Text;
                string inzynier = listaAktywnychSortow.SelectedItems[0].SubItems[5].Text;

                EdytujSort edytujSort = new EdytujSort(numerCzesci, wada, prefiks, status, data, inzynier);
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
                item.SubItems.Add(row["numerCzesci"].ToString().Trim());
                item.SubItems.Add(row["linia"].ToString().Trim());
                item.SubItems.Add(row["dataUruchomienia"].ToString().Trim());
                item.SubItems.Add(row["firmaDostawca"].ToString().Trim());
                item.SubItems.Add(row["inzynier"].ToString().Trim());
                item.SubItems.Add(row["opisProblemu"].ToString().Trim());
                item.SubItems.Add((row["status"].ToString().Trim()));
                listaAktywnychSortow.Items.Add(item);
            }
            
        }

        private void btnSlowniki_Click(object sender, EventArgs e)
        {
            Slowniki Slowniki = new Slowniki();
            Slowniki.Show();
        }
    }
}
