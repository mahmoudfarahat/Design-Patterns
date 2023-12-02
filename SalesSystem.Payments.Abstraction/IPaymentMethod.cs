using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments.Abstraction
{
    public interface IPaymentMethod
    {
        Payment Charge(int customerId,double amount);
    }
}
