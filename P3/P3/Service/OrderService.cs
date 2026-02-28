using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    public class OrderService
    {
        private readonly IInvoiceService _invoiceService;
        private readonly INotification _emailService;

        public OrderService(IInvoiceService invoiceService,
                            INotification emailService)
        {
            _invoiceService = invoiceService;
            _emailService = emailService;
        }

        public void Checkout(List<Product> products, string customerEmail)
        {
            _invoiceService.CreateInvoice(products);
            _emailService.SendMessage("message ...", customerEmail);
        }
    }
}
