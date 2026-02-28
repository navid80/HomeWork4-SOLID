using P3;
class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product("Laptop", 1000, new PercentageDiscount(10)),
            new Product("Mouse", 200, new AmountDiscount(30)),
            new Product("Keyboard", 300, new AmountDiscount(50)),
            new Product("Watch", 600, new PercentageDiscount(5)),
            new Product("Power", 1200, new AmountDiscount(0))
        };
        IInvoiceService invoiceService = new OnlineInvoiceService();
        INotification emailService = new EmailService();

        var orderService = new OrderService(invoiceService, emailService);

        orderService.Checkout(products, "customer@test.com");
    }
}

// پاسخ سوال ها در pdf Answer questions 1 to 6 می باشد