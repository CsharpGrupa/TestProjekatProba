using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjekatProba.Views
{
    public partial class Prodaja : Form
    {
        public Prodaja()
        {
            InitializeComponent();
        }
        private void Prodaja_Load(object sender, EventArgs e)
        {
            label1.Text += LogonPage.username;

        }
        // ovo je btn za personalno 
        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personalno p = new Personalno();
            p.Show();
        }

        private void btnIzmeniPorudzbinu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Porudzbina p = new Porudzbina();
            p.Show();
        }

        private void btnUnesiNovuPorudzbinu_Click(object sender, EventArgs e)
        {
            this.Hide();
            NovaPorudzbina np = new NovaPorudzbina();
            np.Show();
        }
    }
}
