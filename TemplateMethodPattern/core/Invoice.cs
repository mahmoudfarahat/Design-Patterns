﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.core
{
    internal class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }

        public double DiscountPercentage { get; set; }
        public double TotalPrice => Lines.Sum(x => x.Quantity * x.UnitPrice);

        public double Taxes { get; set; }
        public double NetPrice => TotalPrice + Taxes - TotalPrice * DiscountPercentage;
    }
}
