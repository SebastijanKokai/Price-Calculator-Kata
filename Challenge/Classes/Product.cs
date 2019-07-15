using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Classes
{
    public class Product
    {
        decimal price;

        public double Discount { get; set; }

        public string NameOfProduct { get; set; }

        public int Upc { get; set; }

        public decimal Price
        {
            get
            {
                return Decimal.Round(this.price, 2);
            }
            set
            {
                this.price = value;
            }
        }

        public double Tax { get; set; }

        public override string ToString()
        {
            //display 'no discount' if discount == 0
            string discount = WhatIsDiscount() == 0 ? "no discount" : "$"+WhatIsDiscount().ToString();

            //return 
            //$"Sample product: {NameOfProduct}, UPC = {Upc.ToString()}, Price = ${Price.ToString()}\n" +
            //$"Tax = {Tax*100}% Discount = {Discount*100}%\n" +
            //$"Tax amount = ${WhatIsTax()}; Discount amount = {discount}\n" +
            //$"Price before = ${Price}, Price after = ${(double)Price + WhatIsTax() - WhatIsDiscount()}\n\n";

            return
            $"Sample product: {NameOfProduct}, UPC = {Upc.ToString()}, Price = ${Price.ToString()}\n" +
            $"Tax = {Tax * 100}% Discount = {Discount * 100}%\n\n";
        }

        public double WhatIsTax()
        {
            return Math.Round((double)Price * Tax,2);
        }

        public double WhatIsDiscount()
        {
            return Math.Round((double)Price * Discount,2);
        }
    }
}
