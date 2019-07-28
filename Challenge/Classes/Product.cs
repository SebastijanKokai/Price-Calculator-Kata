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

        public double discountCap = -1;

        public static UniversalDiscount universalDiscount;

        public SelectiveDiscount selectiveDiscount;

        string nameOfProduct;

        int upc;

        //List for all additional costs this product has
        public List<AdditionalCosts> additionalCosts = new List<AdditionalCosts>();

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
            get { return universalDiscount.Discount; }
            set { universalDiscount.Discount = value; }
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

        public double PriceAfterTaxes()
        {
             return ((double)Price + WhatIsTax() - WhatIsUniversalDiscount() - WhatIsSelectiveDiscount());
        }

        public double PriceAfterAddCost()
        {
            double addCost = 0;
            for (int i = 0; i < additionalCosts.Count; i++)
            {
                addCost += additionalCosts[i].Amount;
            }
            return addCost;
        }


        public static double Tax { get; set; } = 0.2;

        public double WhatIsTax()
        {
            double discountedMoney = 0;
            //is it beforeTax? is the UPC discount > 0? if not, skip
            if (selectiveDiscount.Discount > 0 && selectiveDiscount.beforeTax)
            {
                discountedMoney += ((double)Price * selectiveDiscount.Discount);
            }
            //is the universalDiscount beforeTax? is it > 0? if not, skip
            if(universalDiscount.beforeTax && universalDiscount.Discount > 0)
            {
                discountedMoney += ((double)Price * universalDiscount.Discount);
            }

            //if both are afterTax, then discountedMoney = 0, so nothing changes
            double price = ((double)Price - discountedMoney) * Tax;
            
            return Math.Round(price, 2);
        }

        public double WhatIsUniversalDiscount()
        {
            double discountedMoney = 0;
            if (selectiveDiscount.Discount > 0 && selectiveDiscount.beforeTax && !universalDiscount.beforeTax)
            {
                discountedMoney += ((double)Price * selectiveDiscount.Discount);
            }

            double price = ((double)Price - discountedMoney) * UniversalDiscount;

            // for discount cap
            if (price > discountCap && discountCap > 0)
            {
                price = discountCap;
            }

            return Math.Round(price,2);
        }

        public double WhatIsSelectiveDiscount()
        {
            if (selectiveDiscount.Discount > 0)
            {
                double discountedMoney = 0;
                if (universalDiscount.beforeTax && universalDiscount.Discount > 0 && !selectiveDiscount.beforeTax)
                {
                    discountedMoney += ((double)Price * universalDiscount.Discount);
                }
                double price = ((double)Price - discountedMoney) * selectiveDiscount.Discount;

                // for discount cap
                if (price > discountCap && discountCap > 0)
                {
                    price = discountCap;
                }

                return Math.Round(price, 2);
            }
            return 0;
        }

        public double ReturnAdditiveDiscount()
        {
            double additiveDiscount = WhatIsSelectiveDiscount() + WhatIsUniversalDiscount();

            // for discount cap
            if (additiveDiscount > discountCap && discountCap > 0)
                additiveDiscount = discountCap;

            return additiveDiscount;
        }

        public double ReturnMultiplicativeDiscount()
        {
            double multiplicativeDiscount = 0;

            if (universalDiscount.Discount > 0 & selectiveDiscount.Discount > 0)
            {
                double universalDiscount = WhatIsUniversalDiscount();
                double upcDiscount = ((double)Price - universalDiscount) * selectiveDiscount.Discount;
                multiplicativeDiscount = upcDiscount + universalDiscount;

                // for discount cap
                if (multiplicativeDiscount > discountCap && discountCap > 0)
                    multiplicativeDiscount = discountCap;
            }

            return multiplicativeDiscount;
        }
    }

    //using struct so I don't get 'object reference not set to an instance of an object' error
    public struct SelectiveDiscount
    {
        public double Discount { get; set; }

        public bool beforeTax;
    }

    public struct UniversalDiscount
    {
        public double Discount { get; set; }

        public bool beforeTax;
    }

    public struct AdditionalCosts
    {
        public string NameOfAdditionalCost { get; set; }
        public bool IsPercentage { get; set; }
        public double Amount { get; set; }
    }

}
