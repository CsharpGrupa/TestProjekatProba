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
    public partial class LogonPage : Form
    {
        public static string username;

        public LogonPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                TEST_DOOEntities db = new TEST_DOOEntities();
                if (db.Users.Where(u => u.Username == txtBoxUsername.Text && u.Password == txtBoxPass.Text).Count() > 0)
                {
                    username = txtBoxUsername.Text;
                    this.Hide();
                    Prodaja prodaja = new Prodaja();
                    prodaja.Show();

                }


            }
            catch
            {

                MessageBox.Show("Nije validan user!");

            }
        }
    }
}
