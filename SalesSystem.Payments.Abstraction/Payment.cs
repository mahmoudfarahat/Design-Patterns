using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payments.Abstraction
{
    public class Payment
    {
        public int CustomerId { get; set; }
        public double ChargedAmount { get; set; }
        public Guid RefereneNumber { get; set; }
    }
}
