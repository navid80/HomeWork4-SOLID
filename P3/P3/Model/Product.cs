using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        private readonly IDiscount _discount;

        public Product(string title, decimal price, IDiscount discount)
        {
            Title = title;
            Price = price;
            _discount = discount;
        }
        public decimal GetFinalPrice()
        {
            return _discount.ApplyDiscount(Price);
        }

    }
}
