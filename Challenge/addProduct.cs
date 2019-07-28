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
        public Product product = new Product();

        private mainForm main = null;
        public addProduct(Form callingForm)
        {
            main = callingForm as mainForm;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //checking if there is an existing UPC already
                foreach (Product product in mainForm.products)
                {
                    if (product.Upc == Int32.Parse(txtBoxUPC.Text))
                        throw new Exception("UPC already in use.");
                }

                product.Upc = Int32.Parse(txtBoxUPC.Text);
                product.NameOfProduct = txtBoxName.Text;
                product.Price = Decimal.Parse(txtBoxPrice.Text);

                mainForm.products.Add(product);
                main.cbBoxProducts.Items.Add(product.Upc);
               //Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdditionalCostsButton_Click(object sender, EventArgs e)
        {
            additionalCostsForm form = new additionalCostsForm(this);
            form.ShowDialog();
        }

    }
}
