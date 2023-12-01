using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPatterm.core
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
                {
             new Customer
            {
                 Id = 1,
                 Name = "Mahmoud Farahat",
                 Category= CustomerCategory.Gold
            },
             new Customer
             {
                Id = 2,
                 Name = "ALi Farahat",
                 Category = CustomerCategory.Sliver
             },
              new Customer
             {
                Id = 3,
                 Name = "Ahmed Omar",
                 Category = CustomerCategory.None
             }
            };
        }
    }
}
