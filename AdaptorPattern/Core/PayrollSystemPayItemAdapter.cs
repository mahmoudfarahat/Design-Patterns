using PayrollSystem.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.Core
{
    public class PayrollSystemPayItemAdapter
    {
        private readonly PayItem _payItem;

        // inhertiance or composition
        //> composition
        public PayrollSystemPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }

        //readonly in Adapter
        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 : _payItem.Value;
    }
}
