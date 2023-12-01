using TemplateMethodPattern.core.DiscountStrategies;
using TemplateMethodPattern.core;
using TemplateMethodPattern.core.ShoppingCarts;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new CustomerDataReader().GetCustomers();
            var items = new ItemDataReader().GetItems();
            while (true)
            {
                Console.WriteLine("Customer List: ");
                foreach (var customer in customers)
                {
                    Console.WriteLine($"\t {customer.Id}. {customer.Name} ({customer.Category}) ");
                }
                Console.WriteLine();

                Console.WriteLine("Item List: ");
                foreach (var item in items)
                {
                    Console.WriteLine($"\t {item.Id}. {item.Name} ({item.UnitPrice:0.00}) ");
                }
                Console.WriteLine();


                Console.Write($"Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());

                Console.Write("Select shopping Cart Type (Online | InStore): ");
                ShoppingCart shoppingCart = Console.ReadLine().Equals("online", StringComparison.OrdinalIgnoreCase) ? 
                    new OnlineShoppingCart(): new InStoreShoppingCart();

                while(true)
                {
                    Console.Write("Enter Item Id (0 to complete the order): ");
                    var itemId = int.Parse(Console.ReadLine());

                    if(itemId == 0 )
                    {
                        break;
                    }
                    Console.Write("Enter item Quantity: ");
                    var quantity = double.Parse(Console.ReadLine());
                    var item = items.First(x => x.Id == itemId);
                    shoppingCart.AddItem(itemId, quantity, item.UnitPrice);


                }

                
            
                var selectedCustomer = customers.First(x => x.Id == customerId);



                //ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStragtegyFactory().CreateCustomerDiscountStrategy(selectedCustomer.Category);


                //var invoiceManager = new InvoiceManager();
                //invoiceManager.SetDiscountStrategy(customerDiscountStrategy);

                //var invoice = invoiceManager.CreateInvoice(selectedCustomer, quantity, unitPrice);

                shoppingCart.Checkout(selectedCustomer);
                //Console.WriteLine($"Invoice created for customer `{selectedCustomer.Name}` with total price : {invoice.NetPrice} ");
                 Console.WriteLine("Press any key to create another invoice");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------");

            };


        }
    }
}
