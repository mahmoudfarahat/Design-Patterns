using FactoryMethodPattern.core;
using FactoryMethodPattern.core.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class CustomerDiscountStragtegyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategy(CustomerCategory category)
        {
            if ( category == CustomerCategory.Sliver)
            {
                return new SilverCustomerDiscountStrategy();
            }
            else if (category == CustomerCategory.Gold)
            {
                return new GoldCustomerDiscountStrategy();
            }
            return new NullDiscountStrategies();
        }
    }
}
