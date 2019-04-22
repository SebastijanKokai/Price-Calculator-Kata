using Challenge.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge
{
    public partial class addProduct : Form
    {
        string nameOfProduct;
        public addProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();
                product.NameOfProduct = txtBoxName.Text;
                product.Price = Decimal.Parse(txtBoxPrice.Text);
                product.Upc = Int32.Parse(txtBoxUPC.Text);
                product.Tax = 0.2;
                mainForm.products.Add(product);
                nameOfProduct = product.NameOfProduct;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }

        public string NameOfProduct
        {
            get { return nameOfProduct; }
        }
    }
}
