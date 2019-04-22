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
    public partial class mainForm : Form
    {
        public static List<Product> products;

        public mainForm()
        {
            //initialization of list
            products = new List<Product>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeTaxButton_Click(object sender, EventArgs e)
        {
            //changing the tax for a product
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].NameOfProduct == (string)cbBoxProducts.SelectedItem)
                {
                    products[i].Tax = Convert.ToDouble(txtBoxChangedTax.Text);
                }
            }
        }

        private void changeDiscountButton_Click(object sender, EventArgs e)
        {
            //changing the discount for a product
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].NameOfProduct == (string)cbBoxProducts.SelectedItem)
                {
                    products[i].Discount = Convert.ToDouble(txtBoxChangedDiscount.Text);
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //I used a getter to get the Name of the product
            addProduct form = new addProduct();
            DialogResult dialogResult = form.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                cbBoxProducts.Items.Add(form.NameOfProduct);
            }
        }

        private void cbBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void writeProductsButton_Click(object sender, EventArgs e)
        {
            //writing down all products and their attributes
            displayRichTxtBox.Clear();
            foreach(Product product in products)
            {
                displayRichTxtBox.Text += product.ToString();
                   
            }
        }

        
    }
}
