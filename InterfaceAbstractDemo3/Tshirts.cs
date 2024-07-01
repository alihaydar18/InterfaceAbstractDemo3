using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo3
{
    public class Tshirts : DiscountManager
    {
        public Tshirts(int id, string productName, double productPrice, int discountOption)
            : base(id, productName, productPrice, discountOption)
        {
        }
    }
}