namespace Platforma.Zakladki
{
    partial class NowySort
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
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.tbNumerCzesci = new System.Windows.Forms.TextBox();
            this.labelNumerCzesci = new System.Windows.Forms.Label();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.labelLinia = new System.Windows.Forms.Label();
            this.labelDataUruchomienia = new System.Windows.Forms.Label();
            this.labelFirma = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.RichTextBox();
            this.labelOpisProblemu = new System.Windows.Forms.Label();
            this.btnDodajSort = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.labelInformacja = new System.Windows.Forms.Label();
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.cbLinia = new System.Windows.Forms.ComboBox();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.cbInzynier = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(21, 43);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(172, 20);
            this.tbPrefix.TabIndex = 0;
            // 
            // tbNumerCzesci
            // 
            this.tbNumerCzesci.Location = new System.Drawing.Point(21, 85);
            this.tbNumerCzesci.Name = "tbNumerCzesci";
            this.tbNumerCzesci.Size = new System.Drawing.Size(172, 20);
            this.tbNumerCzesci.TabIndex = 1;
            // 
            // labelNumerCzesci
            // 
            this.labelNumerCzesci.AutoSize = true;
            this.labelNumerCzesci.Location = new System.Drawing.Point(18, 69);
            this.labelNumerCzesci.Name = "labelNumerCzesci";
            this.labelNumerCzesci.Size = new System.Drawing.Size(71, 13);
            this.labelNumerCzesci.TabIndex = 9;
            this.labelNumerCzesci.Text = "Numer częsci";
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Location = new System.Drawing.Point(18, 27);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(91, 13);
            this.labelPrefix.TabIndex = 10;
            this.labelPrefix.Text = "Identyfikator sortu";
            // 
            // labelLinia
            // 
            this.labelLinia.AutoSize = true;
            this.labelLinia.Location = new System.Drawing.Point(18, 114);
            this.labelLinia.Name = "labelLinia";
            this.labelLinia.Size = new System.Drawing.Size(29, 13);
            this.labelLinia.TabIndex = 11;
            this.labelLinia.Text = "Linia";
            // 
            // labelDataUruchomienia
            // 
            this.labelDataUruchomienia.AutoSize = true;
            this.labelDataUruchomienia.Location = new System.Drawing.Point(274, 31);
            this.labelDataUruchomienia.Name = "labelDataUruchomienia";
            this.labelDataUruchomienia.Size = new System.Drawing.Size(122, 13);
            this.labelDataUruchomienia.TabIndex = 13;
            this.labelDataUruchomienia.Text = "Data uruchomienia sortu";
            // 
            // labelFirma
            // 
            this.labelFirma.AutoSize = true;
            this.labelFirma.Location = new System.Drawing.Point(274, 69);
            this.labelFirma.Name = "labelFirma";
            this.labelFirma.Size = new System.Drawing.Size(134, 13);
            this.labelFirma.TabIndex = 14;
            this.labelFirma.Text = "Firma dostarczająca części";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inżynier odpowiedzialny za części";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(21, 179);
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(428, 95);
            this.tbOpis.TabIndex = 16;
            this.tbOpis.Text = "";
            // 
            // labelOpisProblemu
            // 
            this.labelOpisProblemu.AutoSize = true;
            this.labelOpisProblemu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpisProblemu.Location = new System.Drawing.Point(191, 156);
            this.labelOpisProblemu.Name = "labelOpisProblemu";
            this.labelOpisProblemu.Size = new System.Drawing.Size(98, 20);
            this.labelOpisProblemu.TabIndex = 17;
            this.labelOpisProblemu.Text = "Opis problemu";
            // 
            // btnDodajSort
            // 
            this.btnDodajSort.Location = new System.Drawing.Point(466, 74);
            this.btnDodajSort.Name = "btnDodajSort";
            this.btnDodajSort.Size = new System.Drawing.Size(138, 92);
            this.btnDodajSort.TabIndex = 19;
            this.btnDodajSort.Text = "Dodaj sort";
            this.btnDodajSort.UseVisualStyleBackColor = true;
            this.btnDodajSort.Click += new System.EventHandler(this.btnDodajSort_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(466, 179);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(138, 95);
            this.btnZamknij.TabIndex = 18;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // labelInformacja
            // 
            this.labelInformacja.AutoSize = true;
            this.labelInformacja.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformacja.Location = new System.Drawing.Point(462, 43);
            this.labelInformacja.Name = "labelInformacja";
            this.labelInformacja.Size = new System.Drawing.Size(48, 22);
            this.labelInformacja.TabIndex = 20;
            this.labelInformacja.Text = "Błąd";
            this.labelInformacja.Visible = false;
            this.labelInformacja.Click += new System.EventHandler(this.labelInformacja_Click);
            // 
            // dataPicker
            // 
            this.dataPicker.Location = new System.Drawing.Point(277, 43);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(172, 20);
            this.dataPicker.TabIndex = 21;
            // 
            // cbLinia
            // 
            this.cbLinia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLinia.FormattingEnabled = true;
            this.cbLinia.Location = new System.Drawing.Point(21, 131);
            this.cbLinia.Name = "cbLinia";
            this.cbLinia.Size = new System.Drawing.Size(172, 21);
            this.cbLinia.TabIndex = 22;
            // 
            // cbFirma
            // 
            this.cbFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Location = new System.Drawing.Point(277, 85);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(172, 21);
            this.cbFirma.TabIndex = 23;
            // 
            // cbInzynier
            // 
            this.cbInzynier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInzynier.FormattingEnabled = true;
            this.cbInzynier.Location = new System.Drawing.Point(277, 132);
            this.cbInzynier.Name = "cbInzynier";
            this.cbInzynier.Size = new System.Drawing.Size(172, 21);
            this.cbInzynier.TabIndex = 24;
            // 
            // NowySort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 282);
            this.Controls.Add(this.cbInzynier);
            this.Controls.Add(this.cbFirma);
            this.Controls.Add(this.cbLinia);
            this.Controls.Add(this.dataPicker);
            this.Controls.Add(this.labelInformacja);
            this.Controls.Add(this.btnDodajSort);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.labelOpisProblemu);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelFirma);
            this.Controls.Add(this.labelDataUruchomienia);
            this.Controls.Add(this.labelLinia);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.labelNumerCzesci);
            this.Controls.Add(this.tbNumerCzesci);
            this.Controls.Add(this.tbPrefix);
            this.Name = "NowySort";
            this.Text = "Dodaj nowe sortowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrefix;
        private System.Windows.Forms.TextBox tbNumerCzesci;
        private System.Windows.Forms.Label labelNumerCzesci;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Label labelLinia;
        private System.Windows.Forms.Label labelDataUruchomienia;
        private System.Windows.Forms.Label labelFirma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox tbOpis;
        private System.Windows.Forms.Label labelOpisProblemu;
        private System.Windows.Forms.Button btnDodajSort;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.Label labelInformacja;
        private System.Windows.Forms.DateTimePicker dataPicker;
        private System.Windows.Forms.ComboBox cbLinia;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.ComboBox cbInzynier;
    }
}