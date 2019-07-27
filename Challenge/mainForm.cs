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
                    foreach (Product product in products)
                    {
                        if((int)cbBoxProducts.SelectedItem == product.Upc)
                        {
                            product.selectiveDiscount.Discount = Convert.ToDouble(txtBoxChangedDiscount.Text);

                            DialogResult result = MessageBox.Show("Do you want the discount after tax? ('No' is for before tax)", "Taxing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.No)
                                product.selectiveDiscount.beforeTax = true;
                        }
                    }
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
                        string display = "";

                        double addCost = 0;
                        double price = (double)product.Price;
                        double tax = product.WhatIsTax();
                        double discounts = 0;

                        //this string is used so I can display only necessary attributes
                        display += $"Cost: ${price}\n";

                        if (tax > 0)
                            display += $"Tax: ${tax}\n";

                        double uniDiscount = product.WhatIsUniversalDiscount();
                        double upcDiscount = product.WhatIsSelectiveDiscount();

                        if (uniDiscount > 0 || upcDiscount > 0)
                        {
                            if (uniDiscount > 0 && upcDiscount > 0)
                            {
                                DialogResult result = MessageBox.Show("Do you want additive discount? ('No' is for multiplicative)", "Additive/Multiplicative Discount", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.No)
                                {
                                    discounts = product.ReturnMultiplicativeDiscount();
                                }
                                else
                                {
                                    discounts = product.ReturnAdditiveDiscount();
                                }
                            }
                            else
                            {
                                discounts = product.ReturnAdditiveDiscount();
                            }

                            display += $"Discounts: ${discounts}\n";
                        }

                            
                        

                        for (int i = 0; i < product.additionalCosts.Count; i++)
                        {
                            string nameOf = product.additionalCosts[i].NameOfAdditionalCost;
                            bool isPercentage = product.additionalCosts[i].IsPercentage;
                            double amount = product.additionalCosts[i].Amount;

                            string sign = isPercentage ? "%" : "$";

                            if (sign == "%")
                                amount = Math.Round(price*amount, 2);

                            display += $"{nameOf}: ${amount}\n";

                            addCost += amount;
                        }

                        double total = Math.Round(price + tax + addCost - discounts,2);

                        display += $"Total: ${total}";

                        displayRichTxtBox.Text = display;

                        //If discount is higher than 0, show the amount
                        if (discounts > 0)
                        MessageBox.Show("Discount of product: $"  + discounts);

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
                Product.UniversalDiscount = Convert.ToDouble(txtBoxUniDisc.Text);

                DialogResult result = MessageBox.Show("Do you want the discount after tax? ('No' is for before tax)", "Taxing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    Product.universalDiscount.beforeTax = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
