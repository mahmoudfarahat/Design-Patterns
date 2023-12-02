using SalesSystem.Payments.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.core.Payments
{
    internal class VisaPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            var commission = amount < 10000 ? amount * .02 : 0;
            return new Payment
            {
                CustomerId = customerId,
                ChargedAmount = amount + commission,
                RefereneNumber = Guid.NewGuid()
            };
        }
    }
}
