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
                if(products[i].NameOfProduct == (string)cbBoxProducts.SelectedValue)
                {
                    MessageBox.Show("Hello love.");
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
            richTextBox1.Clear();
            foreach(Product product in products)
            {
                richTextBox1.Text += (product.ToString() + "\n" + 
                    "Product price reported as $" + product.Price + 
                    " before tax and $" + 
                    Math.Round((double)product.Price * (1 + product.Tax),2).ToString()+
                    " after " + product.Tax*100 + "% tax" + "\n");
            }
        }

        public void addItem(string item)
        {
            cbBoxProducts.Items.Add(item);
        }
    }
}
