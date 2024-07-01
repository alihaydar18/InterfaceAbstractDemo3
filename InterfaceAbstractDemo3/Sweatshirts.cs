using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3
{
    public class Sweatshirts : DiscountManager
    {
        public Sweatshirts(int id, string productName, double productPrice, int discountOption) : base(id, productName, productPrice, discountOption)
        {
        }
    }
}
