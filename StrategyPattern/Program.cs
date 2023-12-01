using StrategyPattern.core;
using StrategyPattern.core.DiscountStrategies;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();
            while (true)
            {
                Console.WriteLine("Customer List: [1] Mahmoud [2] Ali");
                Console.Write($"Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter item Quantity: ");
                var quantity = double.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price: ");
                var unitPrice = double.Parse(Console.ReadLine());

                var customer = customers.First(x => x.Id == customerId);
                ICustomerDiscountStrategy customerDiscountStrategy = null;
                if(customer.Category == CustomerCategory.Sliver)
                {
                    customerDiscountStrategy = new SilverCustomerDiscountStrategy();
                }else if (customer.Category == CustomerCategory.Gold)
                {
                    customerDiscountStrategy = new GoldCustomerDiscountStrategy();

                }
                
                var invoiceManager = new InvoiceManager();
                invoiceManager.SetDiscountStrategy(customerDiscountStrategy);

                var invoice = invoiceManager.CreateInvoice(customer,quantity,unitPrice);

                Console.WriteLine($"Invoice created for customer `{customer.Name}` with total price : {invoice.NetPrice} ");
                Console.WriteLine("Press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------");
                
            };

         }
    }
}
