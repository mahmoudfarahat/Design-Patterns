﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Core
{
    internal class OrderProcessorProfilingDecorator : IOrderProcessor
    {
        private readonly IOrderProcessor _orderProcessor;

        public OrderProcessorProfilingDecorator(IOrderProcessor orderProcessor)
        {
           _orderProcessor = orderProcessor;
        }

        public void Process(Order order)
        {
            var stopwatch = new Stopwatch();
                stopwatch.Start();
            _orderProcessor.Process(order);
            stopwatch.Stop();
            Console.WriteLine($"Order took `{stopwatch.Elapsed.TotalSeconds}s` to be processed");
        }
    }
}
