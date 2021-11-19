
namespace TestProjekatProba.Views
{
    partial class Prodaja
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
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPorudzbine = new System.Windows.Forms.Button();
            this.btnIzmeniKlijenta = new System.Windows.Forms.Button();
            this.btnNoviKlijent = new System.Windows.Forms.Button();
            this.btnIzmeniPorudzbinu = new System.Windows.Forms.Button();
            this.btnUnesiNovuPorudzbinu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.BackColor = System.Drawing.Color.Maroon;
            this.btnZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnZaposleni.Location = new System.Drawing.Point(371, 22);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(261, 54);
            this.btnZaposleni.TabIndex = 19;
            this.btnZaposleni.Text = "Zaposleni";
            this.btnZaposleni.UseVisualStyleBackColor = false;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(150, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dobrodosli, ";
            // 
            // btnPorudzbine
            // 
            this.btnPorudzbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPorudzbine.Location = new System.Drawing.Point(263, 374);
            this.btnPorudzbine.Name = "btnPorudzbine";
            this.btnPorudzbine.Size = new System.Drawing.Size(261, 54);
            this.btnPorudzbine.TabIndex = 17;
            this.btnPorudzbine.Text = "Porudzbine";
            this.btnPorudzbine.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniKlijenta
            // 
            this.btnIzmeniKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnIzmeniKlijenta.Location = new System.Drawing.Point(440, 275);
            this.btnIzmeniKlijenta.Name = "btnIzmeniKlijenta";
            this.btnIzmeniKlijenta.Size = new System.Drawing.Size(261, 54);
            this.btnIzmeniKlijenta.TabIndex = 16;
            this.btnIzmeniKlijenta.Text = "Izmeni klijenta";
            this.btnIzmeniKlijenta.UseVisualStyleBackColor = true;
            // 
            // btnNoviKlijent
            // 
            this.btnNoviKlijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnNoviKlijent.Location = new System.Drawing.Point(100, 275);
            this.btnNoviKlijent.Name = "btnNoviKlijent";
            this.btnNoviKlijent.Size = new System.Drawing.Size(261, 54);
            this.btnNoviKlijent.TabIndex = 15;
            this.btnNoviKlijent.Text = "Unesi Novog klijenta";
            this.btnNoviKlijent.UseVisualStyleBackColor = true;
            // 
            // btnIzmeniPorudzbinu
            // 
            this.btnIzmeniPorudzbinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnIzmeniPorudzbinu.Location = new System.Drawing.Point(440, 154);
            this.btnIzmeniPorudzbinu.Name = "btnIzmeniPorudzbinu";
            this.btnIzmeniPorudzbinu.Size = new System.Drawing.Size(261, 54);
            this.btnIzmeniPorudzbinu.TabIndex = 14;
            this.btnIzmeniPorudzbinu.Text = "Izmeni Porudzbinu";
            this.btnIzmeniPorudzbinu.UseVisualStyleBackColor = true;
            this.btnIzmeniPorudzbinu.Click += new System.EventHandler(this.btnIzmeniPorudzbinu_Click);
            // 
            // btnUnesiNovuPorudzbinu
            // 
            this.btnUnesiNovuPorudzbinu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnUnesiNovuPorudzbinu.Location = new System.Drawing.Point(100, 154);
            this.btnUnesiNovuPorudzbinu.Name = "btnUnesiNovuPorudzbinu";
            this.btnUnesiNovuPorudzbinu.Size = new System.Drawing.Size(261, 54);
            this.btnUnesiNovuPorudzbinu.TabIndex = 13;
            this.btnUnesiNovuPorudzbinu.Text = "Unesi Novu Porudzbinu";
            this.btnUnesiNovuPorudzbinu.UseVisualStyleBackColor = true;
            this.btnUnesiNovuPorudzbinu.Click += new System.EventHandler(this.btnUnesiNovuPorudzbinu_Click);
            // 
            // Prodaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPorudzbine);
            this.Controls.Add(this.btnIzmeniKlijenta);
            this.Controls.Add(this.btnNoviKlijent);
            this.Controls.Add(this.btnIzmeniPorudzbinu);
            this.Controls.Add(this.btnUnesiNovuPorudzbinu);
            this.Name = "Prodaja";
            this.Text = "Prodaja";
            this.Load += new System.EventHandler(this.Prodaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPorudzbine;
        private System.Windows.Forms.Button btnIzmeniKlijenta;
        private System.Windows.Forms.Button btnNoviKlijent;
        private System.Windows.Forms.Button btnIzmeniPorudzbinu;
        private System.Windows.Forms.Button btnUnesiNovuPorudzbinu;
    }
}