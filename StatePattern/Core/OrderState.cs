using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Core
{
    internal enum OrderState
    {
        Draft,
        Confirmed,
        Canceled,
        UnderProcessing,
        Shipped,
        Delivered,
        Returned
    }
}
