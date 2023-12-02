using SalesSystem.Payments.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.core.ShoppingCarts
{
    internal abstract class ShoppingCart
    {
        private List<InvoiceLine> _lines = new();
        public void AddItem(int itemId, double quantity, double unitPirce)
        {
            _lines.Add(new InvoiceLine { ItemId = itemId, Quantity = quantity, UnitPrice = unitPirce });
        }


        public void Checkout(Customer customer , PaymentProcessor paymentProcessor) {
            var invoice = new Invoice
            {
                Customer = customer,
                 Lines = _lines
            };

            //1- ApplyTaxes(invoice);
            //2- ApplyDiscount(invoice);
            //3- ProcessPayment(invoice);
             ApplyTaxes(invoice);
             ApplyDiscount(invoice);
             ProcessPayment(invoice, paymentProcessor);
        }

    

        private void ApplyTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * .15;
        }

        //template method = abstract
        protected abstract void ApplyDiscount(Invoice invoice);

        private void ProcessPayment(Invoice invoice , PaymentProcessor paymentProcessor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice created for customer `{invoice.Customer.Name}` with net price: {invoice.NetPrice}");

            var payment = paymentProcessor.ProcessorPayment(invoice.Customer.Id, invoice.NetPrice);
            Console.WriteLine($"Customer charger with {payment.ChargedAmount:0.00}, payment ref: {payment.RefereneNumber}");

            Console.ForegroundColor= ConsoleColor.White;
        }


    }
}
