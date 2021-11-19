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
    public partial class Porudzbina : Form
    {
        public Porudzbina()
        {
            InitializeComponent();
        }

        private void Porudzbina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEST_DOODataSet2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.tEST_DOODataSet2.Orders);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.ordersTableAdapter.Update(this.tEST_DOODataSet2.Orders);
                MessageBox.Show("Data Updated...!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
