using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int DiscountOption { get; set; }

        public Products(int id, string productName, double productPrice, int discountOption)
        {
            Id = id;
            ProductName = productName;
            ProductPrice = productPrice;
            DiscountOption = discountOption;
        }
    }
}
