using SalesSystem.Payments.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.core.Payments
{
    internal class VisaPaymentProcesser : PaymentProcessor
    {
        protected override IPaymentMethod CreatPaymentMethod()
        {
           return new VisaPaymentMethod();
        }
    }
}
