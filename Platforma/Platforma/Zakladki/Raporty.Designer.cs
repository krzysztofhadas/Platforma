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
            this.btnStworzRaport = new System.Windows.Forms.Button();
            this.colWady = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.colWady});
            this.listaRaportow.FullRowSelect = true;
            this.listaRaportow.GridLines = true;
            this.listaRaportow.HideSelection = false;
            this.listaRaportow.Location = new System.Drawing.Point(172, 12);
            this.listaRaportow.MultiSelect = false;
            this.listaRaportow.Name = "listaRaportow";
            this.listaRaportow.Size = new System.Drawing.Size(846, 451);
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
            this.colDataUruchomienia.Width = 130;
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
            // btnStworzRaport
            // 
            this.btnStworzRaport.Location = new System.Drawing.Point(12, 12);
            this.btnStworzRaport.Name = "btnStworzRaport";
            this.btnStworzRaport.Size = new System.Drawing.Size(154, 74);
            this.btnStworzRaport.TabIndex = 9;
            this.btnStworzRaport.Text = "Stwórz raport";
            this.btnStworzRaport.UseVisualStyleBackColor = true;
            this.btnStworzRaport.Click += new System.EventHandler(this.btnStworzRaport_Click);
            // 
            // colWady
            // 
            this.colWady.Text = "Wady";
            this.colWady.Width = 206;
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 475);
            this.Controls.Add(this.btnStworzRaport);
            this.Controls.Add(this.listaRaportow);
            this.Name = "Raporty";
            this.Text = "Raporty";
            this.ResumeLayout(false);

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
    }
}