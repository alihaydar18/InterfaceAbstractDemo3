using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3
{
    public class DiscountManager : Products
    {
        public DiscountManager(int id, string productName, double productPrice, int discountOption)
            : base(id, productName, productPrice, discountOption)
        {
        }

        public double GetProductPrice()
        {
            return ProductPrice;
        }

        public void IndirimYap()
        {
            if (DiscountOption == 1)
            {
                ProductPrice = ProductPrice * 0.8;
            }
            else if (DiscountOption == 2)
            {
                ProductPrice = ProductPrice * 0.6;
            }
            else if (DiscountOption == 3)
            {
                ProductPrice = ProductPrice * 0.5;
            }
        }
    }
}
