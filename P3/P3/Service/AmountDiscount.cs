using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class AmountDiscount : IDiscount
    {
        private readonly decimal _amount;
        public AmountDiscount(decimal amount)
        {
            _amount = amount;
        }

        public decimal ApplyDiscount(decimal price)
        {
            return price - _amount;
        }
    }
}
