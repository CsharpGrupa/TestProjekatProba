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
    public partial class Personalno : Form
    {
        public Personalno()
        {
            InitializeComponent();
        }

        private void Personalno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEST_DOODataSet1.Zaposleni' table. You can move, or remove it, as needed.
            this.zaposleniTableAdapter.Fill(this.tEST_DOODataSet1.Zaposleni);
            // TODO: This line of code loads data into the 'tEST_DOODataSet.Employees' table. You can move, or remove it, as needed.

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.zaposleniBindingSource.EndEdit();
                this.zaposleniTableAdapter.Update(this.tEST_DOODataSet1.Zaposleni);
                MessageBox.Show("Data Updated...!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
