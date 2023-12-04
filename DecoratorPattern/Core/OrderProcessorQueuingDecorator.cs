using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
    internal class OrderProcessorQueuingDecorator : IOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;

        private Queue<Order> _order = new();
        public OrderProcessorQueuingDecorator(IOrderProcessor orderProcessor)
        {
           _orderProcessor = orderProcessor;
        }

        public void Process(Order order)
        {
          _order.Enqueue(order);
            Console.WriteLine("Order has been queued");
        }
    }
}
