using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppWithEncapsulation.Model
{
    internal class Product
    {
        private int id;
        private string name;
        private decimal price;
        private double discountPercentage;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public double DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }

        public decimal CalculateCostAfterDiscount()
        {
            decimal discountAmount = Price * (decimal)(DiscountPercentage / 100);
            return Price - discountAmount;
        }
    }

}
