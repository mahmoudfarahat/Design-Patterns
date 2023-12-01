using SimpleFactoryPatterm.core.DiscountStrategies;
using SimpleFactoryPatterm.core;

namespace SimpleFactoryPatterm
{
    internal class Program
    {
    
        
            static void Main(string[] args)
            {
                var dataReader = new CustomerDataReader();
                var customers = dataReader.GetCustomers();
                while (true)
                {
                Console.WriteLine("Customer List: ");
                foreach (var customer in customers)
                {
                    Console.WriteLine($"\t {customer.Id}. {customer.Name} ({customer.Category}) ");
                }
                Console.WriteLine();
                    Console.Write($"Enter Customer ID: ");
                    var customerId = int.Parse(Console.ReadLine());
                    Console.Write("Enter item Quantity: ");
                    var quantity = double.Parse(Console.ReadLine());
                    Console.Write("Enter Unit Price: ");
                    var unitPrice = double.Parse(Console.ReadLine());

                    var selectedCustomer = customers.First(x => x.Id == customerId);

                    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStragtegyFactory().CreateCustomerDiscountStrategy(selectedCustomer.Category);
                

                    var invoiceManager = new InvoiceManager();
                    invoiceManager.SetDiscountStrategy(customerDiscountStrategy);

                    var invoice = invoiceManager.CreateInvoice(selectedCustomer, quantity, unitPrice);

                    Console.WriteLine($"Invoice created for customer `{selectedCustomer.Name}` with total price : {invoice.NetPrice} ");
                    Console.WriteLine("Press any key to create another invoice");
                    Console.ReadKey();
                    Console.WriteLine("-----------------------------------------");

                };

           
        }
    }
}
