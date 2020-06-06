namespace Platforma.Zakladki
{
    partial class Raporty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaRaportow = new System.Windows.Forms.ListView();
            this.colPrefix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumerCzesci = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataUruchomienia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDataZakonczenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInzynier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNorma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKoszt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStworzRaport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNormogodzina = new System.Windows.Forms.TextBox();
            this.tbKosztNormogodziny = new System.Windows.Forms.TextBox();
            this.btnAktualizujKosztSortowania = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaRaportow
            // 
            this.listaRaportow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPrefix,
            this.colNumerCzesci,
            this.colDataUruchomienia,
            this.colDataZakonczenia,
            this.colInzynier,
            this.colWady,
            this.colNorma,
            this.colKoszt});
            this.listaRaportow.FullRowSelect = true;
            this.listaRaportow.GridLines = true;
            this.listaRaportow.HideSelection = false;
            this.listaRaportow.Location = new System.Drawing.Point(163, 12);
            this.listaRaportow.MultiSelect = false;
            this.listaRaportow.Name = "listaRaportow";
            this.listaRaportow.Size = new System.Drawing.Size(1072, 451);
            this.listaRaportow.TabIndex = 8;
            this.listaRaportow.UseCompatibleStateImageBehavior = false;
            this.listaRaportow.View = System.Windows.Forms.View.Details;
            // 
            // colPrefix
            // 
            this.colPrefix.Text = "Identyfikator Sortu";
            this.colPrefix.Width = 105;
            // 
            // colNumerCzesci
            // 
            this.colNumerCzesci.Text = "Numer Części";
            this.colNumerCzesci.Width = 137;
            // 
            // colDataUruchomienia
            // 
            this.colDataUruchomienia.Text = "Data Uruchomienia";
            this.colDataUruchomienia.Width = 106;
            // 
            // colDataZakonczenia
            // 
            this.colDataZakonczenia.Text = "Data zakonczenia";
            this.colDataZakonczenia.Width = 129;
            // 
            // colInzynier
            // 
            this.colInzynier.Text = "Inżynier";
            this.colInzynier.Width = 129;
            // 
            // colWady
            // 
            this.colWady.Text = "Wady";
            this.colWady.Width = 206;
            // 
            // colNorma
            // 
            this.colNorma.Text = "Norma godzinowa szt/h";
            this.colNorma.Width = 132;
            // 
            // colKoszt
            // 
            this.colKoszt.Text = "Koszzt normogodziny";
            this.colKoszt.Width = 124;
            // 
            // btnStworzRaport
            // 
            this.btnStworzRaport.Location = new System.Drawing.Point(3, 302);
            this.btnStworzRaport.Name = "btnStworzRaport";
            this.btnStworzRaport.Size = new System.Drawing.Size(154, 74);
            this.btnStworzRaport.TabIndex = 9;
            this.btnStworzRaport.Text = "Stwórz raport";
            this.btnStworzRaport.UseVisualStyleBackColor = true;
            this.btnStworzRaport.Click += new System.EventHandler(this.btnStworzRaport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Norma godzinowa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Koszt jednej normogodziny";
            // 
            // tbNormogodzina
            // 
            this.tbNormogodzina.Location = new System.Drawing.Point(3, 55);
            this.tbNormogodzina.Name = "tbNormogodzina";
            this.tbNormogodzina.Size = new System.Drawing.Size(154, 20);
            this.tbNormogodzina.TabIndex = 12;
            // 
            // tbKosztNormogodziny
            // 
            this.tbKosztNormogodziny.Location = new System.Drawing.Point(3, 96);
            this.tbKosztNormogodziny.Name = "tbKosztNormogodziny";
            this.tbKosztNormogodziny.Size = new System.Drawing.Size(154, 20);
            this.tbKosztNormogodziny.TabIndex = 13;
            // 
            // btnAktualizujKosztSortowania
            // 
            this.btnAktualizujKosztSortowania.Location = new System.Drawing.Point(3, 122);
            this.btnAktualizujKosztSortowania.Name = "btnAktualizujKosztSortowania";
            this.btnAktualizujKosztSortowania.Size = new System.Drawing.Size(154, 56);
            this.btnAktualizujKosztSortowania.TabIndex = 14;
            this.btnAktualizujKosztSortowania.Text = "Aktualizuj koszt sortowania";
            this.btnAktualizujKosztSortowania.UseVisualStyleBackColor = true;
            this.btnAktualizujKosztSortowania.Click += new System.EventHandler(this.btnAktualizujKosztSortowania_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(3, 382);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(154, 71);
            this.btnZamknij.TabIndex = 15;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 465);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnAktualizujKosztSortowania);
            this.Controls.Add(this.tbKosztNormogodziny);
            this.Controls.Add(this.tbNormogodzina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStworzRaport);
            this.Controls.Add(this.listaRaportow);
            this.Name = "Raporty";
            this.Text = "Raporty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaRaportow;
        private System.Windows.Forms.ColumnHeader colPrefix;
        private System.Windows.Forms.ColumnHeader colNumerCzesci;
        private System.Windows.Forms.ColumnHeader colDataUruchomienia;
        private System.Windows.Forms.ColumnHeader colDataZakonczenia;
        private System.Windows.Forms.Button btnStworzRaport;
        private System.Windows.Forms.ColumnHeader colInzynier;
        private System.Windows.Forms.ColumnHeader colWady;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNormogodzina;
        private System.Windows.Forms.TextBox tbKosztNormogodziny;
        private System.Windows.Forms.Button btnAktualizujKosztSortowania;
        private System.Windows.Forms.ColumnHeader colNorma;
        private System.Windows.Forms.ColumnHeader colKoszt;
        private System.Windows.Forms.Button btnZamknij;
    }
}