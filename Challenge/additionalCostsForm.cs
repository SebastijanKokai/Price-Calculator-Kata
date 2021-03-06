﻿using System;
using Challenge.Classes;
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
    public partial class additionalCostsForm : Form
    {
        private addProduct addProductForm = null;
        public additionalCostsForm(Form callingForm)
        {
            //So I can send some information to the calling form
            addProductForm = callingForm as addProduct;
            InitializeComponent();
        }

        private void ApplyAdditionalCostsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //creating variables for list item
                string nameOf;
                bool isPercentage = radioButtonPerc.Checked;
                decimal amount = Convert.ToDecimal(txtBoxAmount.Text);

                if (isPercentage && (amount <= 0 || amount > 1))
                    throw new Exception("Percentage must be between 0 and 1.");

                if (radioButtonAdministrative.Checked)
                    nameOf = radioButtonAdministrative.Text;
                else if (radioButtonPackaging.Checked)
                    nameOf = radioButtonPackaging.Text;
                else
                    nameOf = radioButtonTransport.Text;
                
                //creating list item
                AdditionalCosts addCost = new AdditionalCosts();
                addCost.NameOfAdditionalCost = nameOf;
                addCost.IsPercentage = isPercentage;
                addCost.Amount = amount;

                //adding product additional costs
                addProductForm.product.AdditionalCosts.Add(addCost);

                MessageBox.Show("Success.");
                txtBoxAmount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadioButtonPerc_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButtonAmount_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
