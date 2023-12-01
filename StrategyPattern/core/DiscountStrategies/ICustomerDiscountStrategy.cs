using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.core.DiscountStrategies
{
    // in strategy pattern we make an interface or abstract class

    internal interface ICustomerDiscountStrategy
    {
        double CalculateDiscount(double totatPrice);
    }
}
