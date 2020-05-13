namespace Platforma.Zakladki
{
    partial class EdytujSort
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
            System.Windows.Forms.Label labelInfo;
            this.labelEdytowanySort = new System.Windows.Forms.Label();
            this.tbWadaCzesci = new System.Windows.Forms.RichTextBox();
            this.btnAktualizujWade = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.listWpisowSortu = new System.Windows.Forms.ListView();
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIlosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CzesciOk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CzesciNok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelStatystyki = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInofrmacjaOWadzie = new System.Windows.Forms.Label();
            this.labelInformacja = new System.Windows.Forms.Label();
            this.btnUsunInformacje = new System.Windows.Forms.Button();
            this.btnDodajWpis = new System.Windows.Forms.Button();
            this.tbIloscNOK = new System.Windows.Forms.TextBox();
            this.tbIloscOK = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIloscWszystkich = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZakonczSort = new System.Windows.Forms.Button();
            labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new System.Drawing.Point(302, 9);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(96, 13);
            labelInfo.TabIndex = 21;
            labelInfo.Text = "Dane o sortowaniu";
            // 
            // labelEdytowanySort
            // 
            this.labelEdytowanySort.AutoSize = true;
            this.labelEdytowanySort.Location = new System.Drawing.Point(12, 9);
            this.labelEdytowanySort.Name = "labelEdytowanySort";
            this.labelEdytowanySort.Size = new System.Drawing.Size(174, 13);
            this.labelEdytowanySort.TabIndex = 1;
            this.labelEdytowanySort.Text = "Informacje na temat sortu częsci nr:";
            // 
            // tbWadaCzesci
            // 
            this.tbWadaCzesci.Location = new System.Drawing.Point(15, 48);
            this.tbWadaCzesci.Name = "tbWadaCzesci";
            this.tbWadaCzesci.Size = new System.Drawing.Size(264, 84);
            this.tbWadaCzesci.TabIndex = 5;
            this.tbWadaCzesci.Text = "";
            // 
            // btnAktualizujWade
            // 
            this.btnAktualizujWade.Location = new System.Drawing.Point(15, 138);
            this.btnAktualizujWade.Name = "btnAktualizujWade";
            this.btnAktualizujWade.Size = new System.Drawing.Size(264, 35);
            this.btnAktualizujWade.TabIndex = 19;
            this.btnAktualizujWade.Text = "Aktualizuj Wadę";
            this.btnAktualizujWade.UseVisualStyleBackColor = true;
            this.btnAktualizujWade.Click += new System.EventHandler(this.btnAktualizujWade_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(15, 510);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(264, 45);
            this.btnZamknij.TabIndex = 20;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // listWpisowSortu
            // 
            this.listWpisowSortu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Data,
            this.columnIlosc,
            this.CzesciOk,
            this.CzesciNok});
            this.listWpisowSortu.FullRowSelect = true;
            this.listWpisowSortu.GridLines = true;
            this.listWpisowSortu.HideSelection = false;
            this.listWpisowSortu.Location = new System.Drawing.Point(305, 25);
            this.listWpisowSortu.MultiSelect = false;
            this.listWpisowSortu.Name = "listWpisowSortu";
            this.listWpisowSortu.Size = new System.Drawing.Size(483, 450);
            this.listWpisowSortu.TabIndex = 22;
            this.listWpisowSortu.UseCompatibleStateImageBehavior = false;
            this.listWpisowSortu.View = System.Windows.Forms.View.Details;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 57;
            // 
            // columnIlosc
            // 
            this.columnIlosc.Text = "Ilosc Sprawdzonych Sztuk";
            this.columnIlosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnIlosc.Width = 175;
            // 
            // CzesciOk
            // 
            this.CzesciOk.Text = "Cześci OK";
            this.CzesciOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CzesciOk.Width = 89;
            // 
            // CzesciNok
            // 
            this.CzesciNok.Text = "Cześci NOK";
            this.CzesciNok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CzesciNok.Width = 82;
            // 
            // labelStatystyki
            // 
            this.labelStatystyki.AutoSize = true;
            this.labelStatystyki.Location = new System.Drawing.Point(302, 526);
            this.labelStatystyki.Name = "labelStatystyki";
            this.labelStatystyki.Size = new System.Drawing.Size(322, 13);
            this.labelStatystyki.TabIndex = 24;
            this.labelStatystyki.Text = "Sprawdzono:   sztuk, 10 sztuk było OK, znaleziono 100 sztuk NOK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Statystyki:";
            // 
            // labelInofrmacjaOWadzie
            // 
            this.labelInofrmacjaOWadzie.AutoSize = true;
            this.labelInofrmacjaOWadzie.Location = new System.Drawing.Point(12, 32);
            this.labelInofrmacjaOWadzie.Name = "labelInofrmacjaOWadzie";
            this.labelInofrmacjaOWadzie.Size = new System.Drawing.Size(72, 13);
            this.labelInofrmacjaOWadzie.TabIndex = 25;
            this.labelInofrmacjaOWadzie.Text = "Wada części:";
            // 
            // labelInformacja
            // 
            this.labelInformacja.AutoSize = true;
            this.labelInformacja.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformacja.Location = new System.Drawing.Point(12, 388);
            this.labelInformacja.Name = "labelInformacja";
            this.labelInformacja.Size = new System.Drawing.Size(50, 18);
            this.labelInformacja.TabIndex = 37;
            this.labelInformacja.Text = "label1";
            this.labelInformacja.Visible = false;
            // 
            // btnUsunInformacje
            // 
            this.btnUsunInformacje.Location = new System.Drawing.Point(15, 330);
            this.btnUsunInformacje.Name = "btnUsunInformacje";
            this.btnUsunInformacje.Size = new System.Drawing.Size(266, 39);
            this.btnUsunInformacje.TabIndex = 36;
            this.btnUsunInformacje.Text = "Usuń Wpis";
            this.btnUsunInformacje.UseVisualStyleBackColor = true;
            this.btnUsunInformacje.Click += new System.EventHandler(this.btnUsunInformacje_Click);
            // 
            // btnDodajWpis
            // 
            this.btnDodajWpis.Location = new System.Drawing.Point(15, 288);
            this.btnDodajWpis.Name = "btnDodajWpis";
            this.btnDodajWpis.Size = new System.Drawing.Size(266, 36);
            this.btnDodajWpis.TabIndex = 35;
            this.btnDodajWpis.Text = "Dodaj Wpis";
            this.btnDodajWpis.UseVisualStyleBackColor = true;
            this.btnDodajWpis.Click += new System.EventHandler(this.btnDodajWpis_Click);
            // 
            // tbIloscNOK
            // 
            this.tbIloscNOK.Location = new System.Drawing.Point(156, 253);
            this.tbIloscNOK.Name = "tbIloscNOK";
            this.tbIloscNOK.Size = new System.Drawing.Size(125, 20);
            this.tbIloscNOK.TabIndex = 34;
            // 
            // tbIloscOK
            // 
            this.tbIloscOK.Location = new System.Drawing.Point(15, 253);
            this.tbIloscOK.Name = "tbIloscOK";
            this.tbIloscOK.Size = new System.Drawing.Size(125, 20);
            this.tbIloscOK.TabIndex = 33;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(156, 214);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(125, 20);
            this.tbData.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Częsci NOK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Częsci OK";
            // 
            // tbIloscWszystkich
            // 
            this.tbIloscWszystkich.Location = new System.Drawing.Point(15, 214);
            this.tbIloscWszystkich.Name = "tbIloscWszystkich";
            this.tbIloscWszystkich.Size = new System.Drawing.Size(125, 20);
            this.tbIloscWszystkich.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ilość sprawdzonych sztuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Data";
            // 
            // btnZakonczSort
            // 
            this.btnZakonczSort.Location = new System.Drawing.Point(15, 465);
            this.btnZakonczSort.Name = "btnZakonczSort";
            this.btnZakonczSort.Size = new System.Drawing.Size(266, 39);
            this.btnZakonczSort.TabIndex = 38;
            this.btnZakonczSort.Text = "Zakończ sort";
            this.btnZakonczSort.UseVisualStyleBackColor = true;
            this.btnZakonczSort.Click += new System.EventHandler(this.btnZakonczSort_Click);
            // 
            // EdytujSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 568);
            this.Controls.Add(this.btnZakonczSort);
            this.Controls.Add(this.labelInformacja);
            this.Controls.Add(this.btnUsunInformacje);
            this.Controls.Add(this.btnDodajWpis);
            this.Controls.Add(this.tbIloscNOK);
            this.Controls.Add(this.tbIloscOK);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbIloscWszystkich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInofrmacjaOWadzie);
            this.Controls.Add(this.labelStatystyki);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listWpisowSortu);
            this.Controls.Add(labelInfo);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnAktualizujWade);
            this.Controls.Add(this.tbWadaCzesci);
            this.Controls.Add(this.labelEdytowanySort);
            this.Name = "EdytujSort";
            this.Text = "EdytujSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEdytowanySort;
        private System.Windows.Forms.RichTextBox tbWadaCzesci;
        private System.Windows.Forms.Button btnAktualizujWade;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.ListView listWpisowSortu;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader columnIlosc;
        private System.Windows.Forms.ColumnHeader CzesciOk;
        private System.Windows.Forms.ColumnHeader CzesciNok;
        private System.Windows.Forms.Label labelStatystyki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInofrmacjaOWadzie;
        private System.Windows.Forms.Label labelInformacja;
        private System.Windows.Forms.Button btnUsunInformacje;
        private System.Windows.Forms.Button btnDodajWpis;
        private System.Windows.Forms.TextBox tbIloscNOK;
        private System.Windows.Forms.TextBox tbIloscOK;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIloscWszystkich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZakonczSort;
    }
}