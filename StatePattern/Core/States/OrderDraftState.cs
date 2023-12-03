using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Core.States
{
    internal class OrderDraftState : IOrderState
    {
        private readonly Order _order;

        public OrderDraftState(Order order)
        {
            _order = order;
        }
        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public void Confirm()
        {
            _order.State = new OrderConfirmState(_order);
        }

        public void Deliver()
        {
            throw new NotImplementedException();
        }

        public void Process()
        {
            throw new NotImplementedException();
        }

        public void Return()
        {
            throw new NotImplementedException();
        }

        public void Ship()
        {
            throw new NotImplementedException();
        }
    }
}
