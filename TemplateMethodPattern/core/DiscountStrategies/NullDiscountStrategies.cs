using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.core.DiscountStrategies
{
    internal class NullDiscountStrategies : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totatPrice)
        {
            return 0;
        }
    }
}
