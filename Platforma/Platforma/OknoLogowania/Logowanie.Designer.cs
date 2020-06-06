namespace Platforma.OknoLogowania
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogowanie = new System.Windows.Forms.Button();
            this.labelInformacja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(12, 26);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(188, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(12, 68);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(188, 20);
            this.tbHaslo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasło";
            // 
            // btnLogowanie
            // 
            this.btnLogowanie.Location = new System.Drawing.Point(12, 95);
            this.btnLogowanie.Name = "btnLogowanie";
            this.btnLogowanie.Size = new System.Drawing.Size(188, 34);
            this.btnLogowanie.TabIndex = 4;
            this.btnLogowanie.Text = "Zaloguj";
            this.btnLogowanie.UseVisualStyleBackColor = true;
            this.btnLogowanie.Click += new System.EventHandler(this.btnLogowanie_Click);
            // 
            // labelInformacja
            // 
            this.labelInformacja.AutoSize = true;
            this.labelInformacja.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelInformacja.Location = new System.Drawing.Point(12, 144);
            this.labelInformacja.Name = "labelInformacja";
            this.labelInformacja.Size = new System.Drawing.Size(43, 17);
            this.labelInformacja.TabIndex = 5;
            this.labelInformacja.Text = "Login";
            this.labelInformacja.Visible = false;
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 173);
            this.Controls.Add(this.labelInformacja);
            this.Controls.Add(this.btnLogowanie);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogowanie;
        private System.Windows.Forms.Label labelInformacja;
    }
}