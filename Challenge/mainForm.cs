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

                            if(rdButtonBTSelective.Checked)
                                product.selectiveDiscount.beforeTax = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            addProduct form = new addProduct(this);
            form.ShowDialog();
        }

        private void cbBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                        //this string is used so I can display only necessary attributes
                        string display = "";

                        //starting variables for displaying costs
                        double addCost = 0;
                        double price = (double)product.Price;
                        double tax = product.WhatIsTax();
                        double discounts = 0;

                        display += $"Cost: ${price}\n";

                        if (tax > 0)
                            display += $"Tax: ${tax}\n";

                        //discounts
                        double uniDiscount = product.WhatIsUniversalDiscount();
                        double upcDiscount = product.WhatIsSelectiveDiscount();

                        if (uniDiscount > 0 || upcDiscount > 0)
                        {
                            if (uniDiscount > 0 && upcDiscount > 0)
                                if (radioButtonMultiplicativeDisc.Checked)
                                    discounts = product.ReturnMultiplicativeDiscount();
                                else
                                    discounts = product.ReturnAdditiveDiscount();
                            else
                                discounts = product.ReturnAdditiveDiscount();

                            display += $"Discounts: ${discounts}\n";
                        }    
                        
                        //additional costs
                        for (int i = 0; i < product.additionalCosts.Count; i++)
                        {
                            string nameOf = product.additionalCosts[i].NameOfAdditionalCost;
                            bool isPercentage = product.additionalCosts[i].IsPercentage;
                            double amount = product.additionalCosts[i].Amount;

                            string sign = isPercentage ? "%" : "$";

                            if (sign == "%")
                                amount = Math.Round(price*amount, 2);

                            display += $"{nameOf}: ${amount}\n";

                            addCost = Math.Round(addCost + amount,2);
                        }

                        double total = Math.Round(price + tax + addCost - discounts,2);

                        display += $"Total: ${total}";

                        displayRichTxtBox.Text = display;

                        //if discount is higher than 0, show the amount
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

                if(rdButtonBTUniversal.Checked)
                    Product.universalDiscount.beforeTax = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ApplyDiscCapButton_Click(object sender, EventArgs e)
        {
            foreach (Product product in products)
            if((int)cbBoxProducts.SelectedItem == product.Upc)
            try
            {
                double discCapAmount = Convert.ToDouble(txtBoxDiscCap.Text);

                //cap must be higher than 0
                if (discCapAmount <= 0)
                    throw new Exception("Number must be higher than 0.");

                //case when percentage is checked
                if (radioButtonPercentageCap.Checked)
                {
                    //percentage interval is [0,1]
                    if (discCapAmount <= 1)
                        discCapAmount = discCapAmount * (double)product.Price;
                    else
                        throw new Exception("Percentages must be between 0 and 1.");
                }

                product.discountCap = discCapAmount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
