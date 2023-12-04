using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
    internal class OrderProcessor : IOrderProcessor
    {
        public virtual void Process(Order order)
        {
            if (order.Lines.Count() == 0)
                throw new Exception("Order is empty");
            Thread.Sleep(Random.Shared.Next(1000, 3000));

            Console.WriteLine("Order has been processed");
        }
    }
}
