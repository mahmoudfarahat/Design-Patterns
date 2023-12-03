using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadPattern.Core
{
    internal class OrderLine
    {
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }

    }
}
