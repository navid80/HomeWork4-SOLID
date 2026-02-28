using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class OnlineInvoiceService : IInvoiceService
    {
        public void CreateInvoice(List<Product> products)
        {
            Console.WriteLine("-------------------- Invoice --------------------");
            decimal total = 0;
            int rowNumber = 1;
            foreach (var product in products)
            {
                var finalPrice = product.GetFinalPrice();
                Console.WriteLine($"{rowNumber}- {product.Title} : {finalPrice}");
                rowNumber++;
                total += finalPrice;
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
