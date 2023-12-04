using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
    internal class OrderProcessorExpectionHandlingDecorator : IOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;

        public OrderProcessorExpectionHandlingDecorator(IOrderProcessor orderProcessor)
        {
            _orderProcessor = orderProcessor;
        }

        public void Process(Order order)
        {
            try
            {
                _orderProcessor.Process(order);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
