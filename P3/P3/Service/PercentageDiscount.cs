using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class PercentageDiscount : IDiscount
    {
        private readonly decimal _percent;

        public PercentageDiscount(decimal percent)
        {
            _percent = percent;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - (price * _percent / 100);
        }
    }
}
