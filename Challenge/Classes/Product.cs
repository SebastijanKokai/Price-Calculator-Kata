using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Classes
{
    public class Product
    {
        string nameOfProduct;
        int upc;
        decimal price;
        double tax;

        public Product()
        {
            tax = 0.2;
        }

        public string NameOfProduct
        {
            get
            {
                return this.nameOfProduct;
            }
            set
            {
                this.nameOfProduct = value;
            }
        }

        public int Upc
        {
            get
            {
                return this.upc;
            }
            set
            {
                this.upc = value;
            }
        }

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

        public double Tax
        {
            get
            {
                return this.tax;
            }
            set
            {
                this.tax = value;
            }
        }

        public override string ToString()
        {
            return "Sample product: " + NameOfProduct +
                ", UPC = " + Upc.ToString() + ", price = $" + Price.ToString();
        }
    }
}
