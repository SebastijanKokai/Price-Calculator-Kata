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

        //by default discount is zero
        static double universalDiscount = 0;

        string nameOfProduct;

        int upc;

        //UPC-discount only for one product
        public static SelectiveDiscount SelectiveDiscount;

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
        public static double UniversalDiscount
        {
            get { return universalDiscount; }
            set { universalDiscount = value; }
        }

        public string NameOfProduct
        {
            get { return nameOfProduct; }
            set { nameOfProduct = value; }
        }

        public int Upc
        {
            get { return upc; }
            set { upc = value; }
        }

        public double PriceAfterTaxes
        {
            get
            {
               return ((double)Price + WhatIsTax() - WhatIsUniversalDiscount() - WhatIsSelectiveDiscount());
            }
        }

        public static double Tax { get; set; } = 0.2;

        //displaying the product attributes
        public override string ToString()
        {
            //display 'no universal discount' if universalDiscount == 0
            string universalDiscount = UniversalDiscount == 0 ? "no discount" : UniversalDiscount*100 + "%";

            //display nothing if selectiveDiscount == 0
            string selectiveDiscount = SelectiveDiscount.Discount == 0 ? "" : $"UPC discount = {SelectiveDiscount.Discount*100}% for UPC = {SelectiveDiscount.UPC}";

            //display no calculation involving this UPC if it has no discounts
            string selectiveDiscountPerc = SelectiveDiscount.UPC != Upc ? "" : $"UPC-discount = ${Price} * {SelectiveDiscount.Discount * 100}% = ${WhatIsSelectiveDiscount()}";

            //display Definition of done
            return
            $"Sample product: {NameOfProduct}, UPC = {Upc}, Price = ${Price}\n" +
            $"Tax = {Tax * 100}%, Universal discount = {universalDiscount}, {selectiveDiscount}\n" +
            $"Tax amount = ${Price} * {Tax * 100}% = ${WhatIsTax()}; " +
            $"discount = ${Price} * {UniversalDiscount * 100}% = ${WhatIsUniversalDiscount()}; " +
            $"{selectiveDiscountPerc}\n" +
            $"Price after: ${PriceAfterTaxes}";

        }

        public double WhatIsTax()
        {
            return Math.Round((double)Price * Tax,2);
        }

        public double WhatIsUniversalDiscount()
        {
            return Math.Round((double)Price * UniversalDiscount,2);
        }

        public double WhatIsSelectiveDiscount()
        {
            if (SelectiveDiscount.UPC == Upc)
                return Math.Round((double)Price * SelectiveDiscount.Discount, 2);
            else
                return 0;
        }

        public double ReturnFullDiscount()
        {
            return WhatIsSelectiveDiscount() + WhatIsUniversalDiscount();
        }
    }

    public struct SelectiveDiscount
    {
        public int UPC { get; set; }
        public double Discount { get; set; }
    }
}
