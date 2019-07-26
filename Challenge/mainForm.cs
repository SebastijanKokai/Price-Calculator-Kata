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
            //changing the tax for products
            try
            {
                Product.Tax = Convert.ToDouble(txtBoxChangedTax.Text);
                txtBoxChangedTax.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeDiscountButton_Click(object sender, EventArgs e)
        {
            //changing the selective discount for a product
            if (cbBoxProducts.SelectedItem != null)
            {
                try
                {
                    Product.SelectiveDiscount.Discount = Convert.ToDouble(txtBoxChangedDiscount.Text);
                    Product.SelectiveDiscount.UPC = Int32.Parse(cbBoxProducts.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtBoxChangedDiscount.Clear();
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //I used a getter to get the Upc of the product
            addProduct form = new addProduct();
            DialogResult dialogResult = form.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                cbBoxProducts.Items.Add(form.UPC);
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

        private void WriteProductButton_Click(object sender, EventArgs e)
        {
            displayRichTxtBox.Clear();

            //program displays discount amount via msgBox for the selected product
            if(cbBoxProducts.SelectedItem != null)
            {
                foreach(Product product in products)
                {
                    if (product.Upc == (int)cbBoxProducts.SelectedItem)
                    {
                        displayRichTxtBox.Text += product.ToString();

                        //If discount is higher than 0, show the amount
                        if(product.WhatIsUniversalDiscount() > 0 || product.WhatIsSelectiveDiscount() > 0)
                        MessageBox.Show("Discount of product: $"  + product.ReturnFullDiscount());

                        //if he found the product, no need to search any longer
                        break;
                    }
                }
            }
        }

        private void applyUniDiscButton_Click(object sender, EventArgs e)
        {

            //applying universal discount for all products
            try
            {
                double discount = Convert.ToDouble(txtBoxUniDisc.Text);

                Product.UniversalDiscount = discount;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
