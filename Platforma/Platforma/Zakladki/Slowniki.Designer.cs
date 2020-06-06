namespace Platforma.Zakladki
{
    partial class Slowniki
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
            this.listSlowniki = new System.Windows.Forms.ListView();
            this.colTyp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWartosc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.TbWartoscSlownika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajWartoscDoSlownika = new System.Windows.Forms.Button();
            this.btnUsunWartoscSlownika = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.cbTypSlownika = new System.Windows.Forms.ComboBox();
            this.labelInformacja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSlowniki
            // 
            this.listSlowniki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTyp,
            this.colWartosc});
            this.listSlowniki.FullRowSelect = true;
            this.listSlowniki.GridLines = true;
            this.listSlowniki.HideSelection = false;
            this.listSlowniki.Location = new System.Drawing.Point(184, 26);
            this.listSlowniki.MultiSelect = false;
            this.listSlowniki.Name = "listSlowniki";
            this.listSlowniki.Size = new System.Drawing.Size(281, 279);
            this.listSlowniki.TabIndex = 23;
            this.listSlowniki.UseCompatibleStateImageBehavior = false;
            this.listSlowniki.View = System.Windows.Forms.View.Details;
            // 
            // colTyp
            // 
            this.colTyp.Text = "Typ Słownika";
            this.colTyp.Width = 100;
            // 
            // colWartosc
            // 
            this.colWartosc.Text = "Wartość słownika";
            this.colWartosc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colWartosc.Width = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Typ słownika";
            // 
            // TbWartoscSlownika
            // 
            this.TbWartoscSlownika.Location = new System.Drawing.Point(12, 84);
            this.TbWartoscSlownika.Name = "TbWartoscSlownika";
            this.TbWartoscSlownika.Size = new System.Drawing.Size(163, 20);
            this.TbWartoscSlownika.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Wartość słownika";
            // 
            // btnDodajWartoscDoSlownika
            // 
            this.btnDodajWartoscDoSlownika.Location = new System.Drawing.Point(12, 117);
            this.btnDodajWartoscDoSlownika.Name = "btnDodajWartoscDoSlownika";
            this.btnDodajWartoscDoSlownika.Size = new System.Drawing.Size(163, 42);
            this.btnDodajWartoscDoSlownika.TabIndex = 28;
            this.btnDodajWartoscDoSlownika.Text = "Dodaj";
            this.btnDodajWartoscDoSlownika.UseVisualStyleBackColor = true;
            this.btnDodajWartoscDoSlownika.Click += new System.EventHandler(this.btnDodajWartoscDoSlownika_Click);
            // 
            // btnUsunWartoscSlownika
            // 
            this.btnUsunWartoscSlownika.Location = new System.Drawing.Point(12, 165);
            this.btnUsunWartoscSlownika.Name = "btnUsunWartoscSlownika";
            this.btnUsunWartoscSlownika.Size = new System.Drawing.Size(163, 42);
            this.btnUsunWartoscSlownika.TabIndex = 29;
            this.btnUsunWartoscSlownika.Text = "Usuń";
            this.btnUsunWartoscSlownika.UseVisualStyleBackColor = true;
            this.btnUsunWartoscSlownika.Click += new System.EventHandler(this.btnUsunWartoscSlownika_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(12, 258);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(163, 42);
            this.btnZamknij.TabIndex = 30;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // cbTypSlownika
            // 
            this.cbTypSlownika.BackColor = System.Drawing.SystemColors.Window;
            this.cbTypSlownika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypSlownika.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbTypSlownika.FormattingEnabled = true;
            this.cbTypSlownika.Location = new System.Drawing.Point(12, 44);
            this.cbTypSlownika.Name = "cbTypSlownika";
            this.cbTypSlownika.Size = new System.Drawing.Size(163, 21);
            this.cbTypSlownika.TabIndex = 31;
            // 
            // labelInformacja
            // 
            this.labelInformacja.AutoSize = true;
            this.labelInformacja.Location = new System.Drawing.Point(12, 221);
            this.labelInformacja.Name = "labelInformacja";
            this.labelInformacja.Size = new System.Drawing.Size(35, 13);
            this.labelInformacja.TabIndex = 32;
            this.labelInformacja.Text = "label3";
            this.labelInformacja.Visible = false;
            // 
            // Slowniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 312);
            this.Controls.Add(this.labelInformacja);
            this.Controls.Add(this.cbTypSlownika);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnUsunWartoscSlownika);
            this.Controls.Add(this.btnDodajWartoscDoSlownika);
            this.Controls.Add(this.TbWartoscSlownika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listSlowniki);
            this.Name = "Slowniki";
            this.Text = "Slowniki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSlowniki;
        private System.Windows.Forms.ColumnHeader colTyp;
        private System.Windows.Forms.ColumnHeader colWartosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbWartoscSlownika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajWartoscDoSlownika;
        private System.Windows.Forms.Button btnUsunWartoscSlownika;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.ComboBox cbTypSlownika;
        private System.Windows.Forms.Label labelInformacja;
    }
}