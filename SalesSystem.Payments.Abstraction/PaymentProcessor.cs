using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments.Abstraction
{
    public abstract class PaymentProcessor
    {
        public Payment ProcessorPayment(int customerId, double amount)
        {
            var paymentMethod = CreatPaymentMethod();
            var payemnt =  paymentMethod.Charge(customerId, amount);

            return payemnt;
        }

        //Factory Method and i dont know it and every system will use it in different way 
        protected abstract IPaymentMethod CreatPaymentMethod();
    }
}
