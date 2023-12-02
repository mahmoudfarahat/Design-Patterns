using SalesSystem.Payments.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.core.Payments
{
    internal class PayPalPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            return new Payment
            {
                CustomerId = customerId,
                ChargedAmount = amount + amount * .05,
                RefereneNumber = Guid.NewGuid()
            };
        }
    }
}
