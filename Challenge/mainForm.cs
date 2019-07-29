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
                decimal tax = Convert.ToDecimal(txtBoxChangedTax.Text);
                if (tax > 1 || tax <= 0)
                    throw new Exception("Percentage must be between 0 and 1.");

                Product.Tax = tax;
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
                            decimal selDiscount = Convert.ToDecimal(txtBoxChangedDiscount.Text);

                            if (selDiscount > 1 || selDiscount <= 0)
                                throw new Exception("Percentage must be between 0 and 1.");

                            product.SelectiveDiscount.Discount = selDiscount;

                            if (rdButtonBTSelective.Checked)
                                product.SelectiveDiscount.BeforeTax = true;
                            else
                                product.SelectiveDiscount.BeforeTax = false;
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
            foreach (Product product in products)
                if(product.Upc == (int)cbBoxProducts.SelectedItem)
                {
                    txtBoxChangedTax.Text = Product.Tax.ToString();
                    txtBoxChangedDiscount.Text = product.SelectiveDiscount.Discount.ToString();
                    txtBoxUniDisc.Text = Product.UniversalDiscount.Discount.ToString();
                    txtBoxDiscCap.Text = product.DiscountCap.ToString();
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
                        //this string is used so I can display only necessary attributes
                        string display = "";

                        //starting variables for displaying costs
                        decimal addCost = 0;
                        decimal price = Math.Round(product.Price, 2);
                        decimal tax = Math.Round(product.WhatIsTax(), 2);
                        decimal discounts = 0;
                        string curr = product.Currency;

                        display += $"Cost: {price} {curr}\n";

                        if (tax > 0)
                            display += $"Tax: {tax} {curr}\n";

                        //discounts
                        decimal uniDiscount = product.WhatIsUniversalDiscount();
                        decimal upcDiscount = product.WhatIsSelectiveDiscount();

                        if (uniDiscount > 0 || upcDiscount > 0)
                        {
                            if (uniDiscount > 0 && upcDiscount > 0)
                                if (radioButtonMultiplicativeDisc.Checked)
                                    discounts = product.ReturnMultiplicativeDiscount();
                                else
                                    discounts = product.ReturnAdditiveDiscount();
                            else
                                discounts = product.ReturnAdditiveDiscount();

                            discounts = Math.Round(discounts, 2);

                            display += $"Discounts: {discounts} {curr}\n";
                        }

                        //additional costs
                        display += product.ReturnAdditionalCostsString();
                        addCost += product.PriceAfterAdditionalCost();

                        //total costs of product
                        decimal total = Math.Round(price + tax + addCost - discounts, 2);

                        display += $"Total: {total} {curr}";

                        displayRichTxtBox.Text = display;

                        //if discount is higher than 0, show the amount
                        if (discounts > 0)
                        MessageBox.Show($"Discount of product: {discounts} {curr}");

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
                decimal uniDiscount = Convert.ToDecimal(txtBoxUniDisc.Text);

                if(uniDiscount > 1 || uniDiscount <= 0)
                    throw new Exception("Percentage must be between 0 and 1.");

                Product.UniversalDiscount.Discount = uniDiscount;

                if (rdButtonBTUniversal.Checked)
                    Product.UniversalDiscount.BeforeTax = true;
                else
                    Product.UniversalDiscount.BeforeTax = false;
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
                decimal discCapAmount = Convert.ToDecimal(txtBoxDiscCap.Text);

                //cap must be higher than 0
                if (discCapAmount <= 0)
                    throw new Exception("Number must be higher than 0.");

                //case when percentage is checked
                if (radioButtonPercentageCap.Checked)
                {
                    //percentage interval is [0,1]
                    if (discCapAmount <= 1)
                        discCapAmount = discCapAmount * product.Price;
                    else
                        throw new Exception("Percentages must be between 0 and 1.");
                }

                product.DiscountCap = discCapAmount;
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
