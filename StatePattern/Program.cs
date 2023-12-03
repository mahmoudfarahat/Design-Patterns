﻿using StatePattern.Core;

namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new ProductDataReader().GetProcuts();
            while(true)
            {
                Console.WriteLine("Item List");
                foreach(var item in products)
                    Console.WriteLine($"\t{item.Id}. {item.Name} ({item.UnitPrice:0.00})");
                Console.WriteLine();

                var order = new Order();
                Console.WriteLine($"Order State: {order.State}");

                while(true)
                {
                    Console.Write("Enter Product ID (0 to complete the order): ");
                    var productId = int.Parse(Console.ReadLine());

                    if (productId == 0)
                        break;

                    Console.Write("Enter Product Quantity: ");
                    var quantity = double.Parse(Console.ReadLine());
                    var product = products.First(x => x.Id == productId);
                    order.Lines.Add(new OrderLine { ProductId = productId, Quantity = quantity , UnitPrice= product.UnitPrice });
                }

                while(true)
                {
                    Console.WriteLine("Select Action") ;
                    Console.WriteLine("\t1. Confirm");
                    Console.WriteLine("\t2. Process");
                    Console.WriteLine("\t3. Cancel");
                    Console.WriteLine("\t4. Ship");
                    Console.WriteLine("\t5. Deliver");
                    Console.WriteLine("\t6. Return");
                    Console.WriteLine("\t0. Exit");

                    var action = int.Parse(Console.ReadLine());

                    try
                    {
                        if (action == 0)
                            break;
                        else if (action == 1)
                            //order.SetState(OrderState.Confirmed);
                            order.Confirm();
                        else if (action == 2)
                            //order.SetState(OrderState.UnderProcessing);
                            order.Process();

                        else if (action == 3)
                            //order.SetState(OrderState.Canceled);
                            order.Cancel();

                        else if (action == 4)
                            //order.SetState(OrderState.Shipped);
                            order.Ship();

                        else if (action == 5)
                            //order.SetState(OrderState.Delivered);
                            order.Deliver();

                        else if (action == 6)
                            //order.SetState(OrderState.Returned);
                            order.Return();


                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Order state changed to: `{order.State}`");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    catch (Exception ex)
                    {


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
                Console.WriteLine("_______________________________________");
            }
        }
    }
}
