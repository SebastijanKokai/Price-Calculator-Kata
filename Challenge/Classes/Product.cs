using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Classes
{
    public class Product
    {
        //fields
        decimal price;
        //I use static for tax and universalDiscount because
        //it applies to all products equally
        static decimal tax = 0.2M;

        string currency = "EUR";

        string nameOfProduct;

        int upc;

        decimal discountCap = -1;

        //List for all additional costs this product has
        List<AdditionalCosts> additionalCosts = new List<AdditionalCosts>();

        //discounts
        static UniversalDiscount universalDiscount = new UniversalDiscount();

        SelectiveDiscount selectiveDiscount = new SelectiveDiscount();

        //properties
        public decimal Price { get => price; set => price = value; }
        public static decimal Tax { get => tax; set => tax = value; }
        public string Currency { get => currency; set => currency = value; }
        public string NameOfProduct { get => nameOfProduct; set => nameOfProduct = value; }
        public int Upc { get => upc; set => upc = value; }
        public decimal DiscountCap { get => discountCap; set => discountCap = value; }
        public List<AdditionalCosts> AdditionalCosts { get => additionalCosts; set => additionalCosts = value; }
        public static UniversalDiscount UniversalDiscount { get => universalDiscount; set => universalDiscount = value; }
        public SelectiveDiscount SelectiveDiscount { get => selectiveDiscount; set => selectiveDiscount = value; }

        //methods
        public decimal PriceAfterTaxes()
        {
             return (Price + WhatIsTax() - WhatIsUniversalDiscount() - WhatIsSelectiveDiscount());
        }

        public decimal PriceAfterAdditionalCost()
        {
            decimal addCost = 0;
            for (int i = 0; i < AdditionalCosts.Count; i++)
            {
                addCost += AdditionalCosts[i].Amount;
            }
            return addCost;
        }

        //returns how much money is tax for the product (not the percentage)
        public decimal WhatIsTax()
        {
            decimal discountedMoney = 0;
            //is it beforeTax? is the UPC discount > 0? if not, skip
            if (SelectiveDiscount.Discount > 0 && SelectiveDiscount.BeforeTax)
            {
                discountedMoney += (Price * SelectiveDiscount.Discount);
            }
            //is the universalDiscount beforeTax? is it > 0? if not, skip
            if(UniversalDiscount.BeforeTax && UniversalDiscount.Discount > 0)
            {
                discountedMoney += (Price * UniversalDiscount.Discount);
            }

            //if both are afterTax, then discountedMoney = 0, so nothing changes
            decimal price = (Price - discountedMoney) * Tax;
            
            return Math.Round(price, 4);
        }

        public decimal WhatIsUniversalDiscount()
        {
            decimal discountedMoney = 0;
            if (SelectiveDiscount.Discount > 0 && SelectiveDiscount.BeforeTax && !UniversalDiscount.BeforeTax)
            {
                discountedMoney += (Price * SelectiveDiscount.Discount);
            }

            decimal price = (Price - discountedMoney) * UniversalDiscount.Discount;

            // for discount cap
            if (price > DiscountCap && DiscountCap > 0)
            {
                price = DiscountCap;
            }

            return Math.Round(price,4);
        }

        public decimal WhatIsSelectiveDiscount()
        {
            if (SelectiveDiscount.Discount > 0)
            {
                decimal discountedMoney = 0;
                if (UniversalDiscount.BeforeTax && UniversalDiscount.Discount > 0 && !SelectiveDiscount.BeforeTax)
                {
                    discountedMoney += (Price * UniversalDiscount.Discount);
                }
                decimal price = (Price - discountedMoney) * SelectiveDiscount.Discount;

                // for discount cap
                if (price > DiscountCap && DiscountCap > 0)
                {
                    price = DiscountCap;
                }

                return Math.Round(price, 4);
            }
            return 0;
        }

        public decimal ReturnAdditiveDiscount()
        {
            decimal additiveDiscount = WhatIsSelectiveDiscount() + WhatIsUniversalDiscount();

            // for discount cap
            if (additiveDiscount > DiscountCap && DiscountCap > 0)
                additiveDiscount = DiscountCap;

            return additiveDiscount;
        }

        public decimal ReturnMultiplicativeDiscount()
        {
            decimal multiplicativeDiscount = 0;

            if (UniversalDiscount.Discount > 0 & SelectiveDiscount.Discount > 0)
            {
                decimal universalDiscount = WhatIsUniversalDiscount();
                decimal upcDiscount = (Price - universalDiscount) * SelectiveDiscount.Discount;
                multiplicativeDiscount = upcDiscount + universalDiscount;

                // for discount cap
                if (multiplicativeDiscount > DiscountCap && DiscountCap > 0)
                    multiplicativeDiscount = DiscountCap;
            }

            return multiplicativeDiscount;
        }

        public string ReturnAdditionalCostsString()
        {
            string display = "";

            for (int i = 0; i < AdditionalCosts.Count; i++)
            {
                string nameOf = AdditionalCosts[i].NameOfAdditionalCost;
                bool isPercentage = AdditionalCosts[i].IsPercentage;
                decimal amount = AdditionalCosts[i].Amount;
                string curr = Currency;

                string sign = isPercentage ? "%" : "";

                if (sign == "%")
                    amount = Price * amount;

                amount = Math.Round(amount, 2);

                display += $"{nameOf}: {amount} {curr}\n";
            }

            return display;
        }
    }

    public class SelectiveDiscount
    {
        decimal discount;

        bool beforeTax;
        public decimal Discount { get => discount; set => discount = value; }
        public bool BeforeTax { get => beforeTax; set => beforeTax = value; }
    }

    public class UniversalDiscount
    {
        decimal discount;

        bool beforeTax;
        public decimal Discount { get => discount; set => discount = value; }
        public bool BeforeTax { get => beforeTax; set => beforeTax = value; }
    }

    public class AdditionalCosts
    {
        string nameOfAdditionalCost;

        bool isPercentage;

        decimal amount;
        public string NameOfAdditionalCost { get => nameOfAdditionalCost; set => nameOfAdditionalCost = value; }
        public bool IsPercentage { get => isPercentage; set => isPercentage = value; }
        public decimal Amount { get => amount; set => amount = value; }
    }

}
