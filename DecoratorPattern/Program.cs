using DecoratorPattern.Core;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.AddLine(1, 5, 1000);
            order.AddLine(2, 3, 2500);
             order.AddLine(3, 4, 1200);

            IOrderProcessor processor = new OrderProcessor();
            processor = new OrderProcessorExpectionHandlingDecorator(processor);
             //processor = new OrderProcessorProfilingDecorator(processor);
           processor = new OrderProcessorQueuingDecorator(processor);

            processor.Process(order);

            Console.ReadKey();

        }
    }
}
