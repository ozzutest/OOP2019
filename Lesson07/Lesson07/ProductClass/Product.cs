using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.ProductClass
{
    class Product : IClonable
    {
        public string name;
        public decimal unitPrice;
        public int amount;

        public object CopyProduct()
        {
            return this.MemberwiseClone();
        }

        public Product()
        {

        }

        public Product(string name, decimal unitPrice, int amount)
        {
            this.name = name;
            this.unitPrice = unitPrice;
            this.amount = amount;
        }
    }
}
