namespace Platforma
{
    partial class Menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDodajSort = new System.Windows.Forms.Button();
            this.btnEdytujSort = new System.Windows.Forms.Button();
            this.btnUsunSort = new System.Windows.Forms.Button();
            this.btnZakonczoneSorty = new System.Windows.Forms.Button();
            this.btnRaporty = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.btnListaAktywnychSortów = new System.Windows.Forms.Button();
            this.listaAktywnychSortow = new System.Windows.Forms.ListView();
            this.colPrefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumerCzesci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLinia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataUruchomienia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDostawca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInzynier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDodajSort
            // 
            this.btnDodajSort.Location = new System.Drawing.Point(6, 85);
            this.btnDodajSort.Name = "btnDodajSort";
            this.btnDodajSort.Size = new System.Drawing.Size(149, 53);
            this.btnDodajSort.TabIndex = 0;
            this.btnDodajSort.Text = "Dodaj sort";
            this.btnDodajSort.UseVisualStyleBackColor = true;
            this.btnDodajSort.Click += new System.EventHandler(this.btnDodajSort_Click);
            // 
            // btnEdytujSort
            // 
            this.btnEdytujSort.Location = new System.Drawing.Point(6, 144);
            this.btnEdytujSort.Name = "btnEdytujSort";
            this.btnEdytujSort.Size = new System.Drawing.Size(148, 52);
            this.btnEdytujSort.TabIndex = 1;
            this.btnEdytujSort.Text = "Edytuj sortu";
            this.btnEdytujSort.UseVisualStyleBackColor = true;
            this.btnEdytujSort.Click += new System.EventHandler(this.btnEdytujSort_Click);
            // 
            // btnUsunSort
            // 
            this.btnUsunSort.Location = new System.Drawing.Point(6, 203);
            this.btnUsunSort.Name = "btnUsunSort";
            this.btnUsunSort.Size = new System.Drawing.Size(148, 53);
            this.btnUsunSort.TabIndex = 2;
            this.btnUsunSort.Text = "Usun sort";
            this.btnUsunSort.UseVisualStyleBackColor = true;
            this.btnUsunSort.Click += new System.EventHandler(this.btnUsunSort_Click);
            // 
            // btnZakonczoneSorty
            // 
            this.btnZakonczoneSorty.Location = new System.Drawing.Point(7, 262);
            this.btnZakonczoneSorty.Name = "btnZakonczoneSorty";
            this.btnZakonczoneSorty.Size = new System.Drawing.Size(148, 53);
            this.btnZakonczoneSorty.TabIndex = 3;
            this.btnZakonczoneSorty.Text = "Zakończone sorty";
            this.btnZakonczoneSorty.UseVisualStyleBackColor = true;
            this.btnZakonczoneSorty.Click += new System.EventHandler(this.btnZakonczoneSorty_Click);
            // 
            // btnRaporty
            // 
            this.btnRaporty.Location = new System.Drawing.Point(7, 321);
            this.btnRaporty.Name = "btnRaporty";
            this.btnRaporty.Size = new System.Drawing.Size(148, 53);
            this.btnRaporty.TabIndex = 4;
            this.btnRaporty.Text = "Raporty ";
            this.btnRaporty.UseVisualStyleBackColor = true;
            this.btnRaporty.Click += new System.EventHandler(this.btnRaporty_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(7, 380);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(148, 53);
            this.btnZamknij.TabIndex = 5;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // btnListaAktywnychSortów
            // 
            this.btnListaAktywnychSortów.Location = new System.Drawing.Point(7, 26);
            this.btnListaAktywnychSortów.Name = "btnListaAktywnychSortów";
            this.btnListaAktywnychSortów.Size = new System.Drawing.Size(149, 53);
            this.btnListaAktywnychSortów.TabIndex = 6;
            this.btnListaAktywnychSortów.Text = "Lista aktywnych sortów";
            this.btnListaAktywnychSortów.UseVisualStyleBackColor = true;
            this.btnListaAktywnychSortów.Click += new System.EventHandler(this.btnListaAktywnychSortów_Click);
            // 
            // listaAktywnychSortow
            // 
            this.listaAktywnychSortow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPrefix,
            this.colNumerCzesci,
            this.colLinia,
            this.colDataUruchomienia,
            this.colDostawca,
            this.colInzynier,
            this.colOpis,
            this.colStatus});
            this.listaAktywnychSortow.FullRowSelect = true;
            this.listaAktywnychSortow.GridLines = true;
            this.listaAktywnychSortow.HideSelection = false;
            this.listaAktywnychSortow.Location = new System.Drawing.Point(163, 26);
            this.listaAktywnychSortow.MultiSelect = false;
            this.listaAktywnychSortow.Name = "listaAktywnychSortow";
            this.listaAktywnychSortow.Size = new System.Drawing.Size(870, 407);
            this.listaAktywnychSortow.TabIndex = 7;
            this.listaAktywnychSortow.UseCompatibleStateImageBehavior = false;
            this.listaAktywnychSortow.View = System.Windows.Forms.View.Details;
            // 
            // colPrefix
            // 
            this.colPrefix.Text = "Identyfikator Sortu";
            this.colPrefix.Width = 105;
            // 
            // colNumerCzesci
            // 
            this.colNumerCzesci.Text = "Numer Części";
            this.colNumerCzesci.Width = 108;
            // 
            // colLinia
            // 
            this.colLinia.Text = "Linia";
            this.colLinia.Width = 49;
            // 
            // colDataUruchomienia
            // 
            this.colDataUruchomienia.Text = "Data Uruchomienia";
            this.colDataUruchomienia.Width = 110;
            // 
            // colDostawca
            // 
            this.colDostawca.Text = "Dostawca Części";
            this.colDostawca.Width = 100;
            // 
            // colInzynier
            // 
            this.colInzynier.Text = "Inżynier";
            this.colInzynier.Width = 50;
            // 
            // colOpis
            // 
            this.colOpis.Text = "Opis";
            this.colOpis.Width = 280;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Sort Aktywny";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.listaAktywnychSortow);
            this.Controls.Add(this.btnListaAktywnychSortów);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnRaporty);
            this.Controls.Add(this.btnZakonczoneSorty);
            this.Controls.Add(this.btnUsunSort);
            this.Controls.Add(this.btnEdytujSort);
            this.Controls.Add(this.btnDodajSort);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajSort;
        private System.Windows.Forms.Button btnEdytujSort;
        private System.Windows.Forms.Button btnUsunSort;
        private System.Windows.Forms.Button btnZakonczoneSorty;
        private System.Windows.Forms.Button btnRaporty;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Button btnListaAktywnychSortów;
        private System.Windows.Forms.ListView listaAktywnychSortow;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.ColumnHeader colPrefix;
        private System.Windows.Forms.ColumnHeader colNumerCzesci;
        private System.Windows.Forms.ColumnHeader colLinia;
        private System.Windows.Forms.ColumnHeader colDataUruchomienia;
        private System.Windows.Forms.ColumnHeader colDostawca;
        private System.Windows.Forms.ColumnHeader colInzynier;
        private System.Windows.Forms.ColumnHeader colOpis;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}

