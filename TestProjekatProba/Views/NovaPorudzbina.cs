using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace TestProjekatProba.Views
{
    public partial class NovaPorudzbina : Form
    {
        public NovaPorudzbina()
        {
            InitializeComponent();
            // abc
        }

        private void NovaPorudzbina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEST_DOODataSet4.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.tEST_DOODataSet4.Products);
            // TODO: This line of code loads data into the 'tEST_DOODataSet3.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.tEST_DOODataSet3.OrderDetails);

        }
        public void Fill_Listbox()
        {
            //string constring = "Data Source=DESKTOP-HVV28CM\SQLEXPRESS01;Initial Catalog=TEST_DOO;Integrated Security=True";
            //string query = "select * from TEST_DOO;";
            //SqlConnection conDataBase = new SqlConnection(constring);
            //SqlCommand cmdDataBase = new SqlCommand(query, conDataBase);
            //SqlDataReader myReader;
            //try
            //{
            //    conDataBase.Open();
            //    myReader = cmdDataBase.ExecuteReader();
            //    while (myReader.Read())
            //    {
            //        string sName = myReader.GetString("productname");
            //    }
            //}
            //catch ()
            //{

            //    throw;
            //}
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtshow_TextChanged(object sender, EventArgs e)
        {
    
        }
    }
}
