using StatePattern.Core.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Core
{
    internal class Order
    {
        public Order()
        {
            // in state pattern it should be initail state
            // this = order object  = context of state pattern
            State = new OrderDraftState(this);
        }

        public IOrderState State { get; internal set; }
        public List<OrderLine> Lines { get; set; } = new();

        //public void SetState(OrderState newState)
        //{
        //    if (
        //        (State == OrderState.Draft && newState != OrderState.Confirmed) ||
        //        (State == OrderState.Confirmed && newState != OrderState.Canceled && newState != OrderState.UnderProcessing) |
        //        (State == OrderState.UnderProcessing && newState != OrderState.Shipped) ||
        //        (State == OrderState.Shipped && newState != OrderState.Delivered) ||
        //        (State == OrderState.Delivered && newState != OrderState.Returned)  
        //         )
        //        throw new InvalidOperationException($"Moving from state `{State}` to state `{newState}` is not supported ");
        //        else
        //            State = newState;
        //}
        public void Confirm()
        {
            State.Confirm();
        }
        public void Cancel()
        {
            State.Cancel();
        }
        public void Process()
        {
            State.Process();
        }
        public void Ship()
        {
            State.Ship();
        }
        public void Deliver()
        {
            State.Deliver();
        }

        public void Return()
            {
            State.Return();

        }

    }
}
