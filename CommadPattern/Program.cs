using CommadPattern.Core;
using CommadPattern.Core.Commands;

namespace CommadPattern
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            var laptop = new Product(1, "Laptop", 20000, 10);
            var keyboard = new Product(2, "keyboard", 300, 50);
           var mouse = new Product(3, "mouse", 150, 70);
            while (true)
            {
                var order = new Order();
                var invoker = new CommandInvoker();

                while (true) {
                    Console.WriteLine("Select one of the below commands:");
                    Console.WriteLine("\t1 Add Laptop");
                    Console.WriteLine("\t2 Add Keyboard");
                    Console.WriteLine("\t3 Add Add Mouse");
                    Console.WriteLine("\t4 Save Macro ");
                    Console.WriteLine("\t5  Reply Macro");

                    Console.WriteLine("\t6 Undo");
                    Console.WriteLine("\t7 Redo");

                    Console.WriteLine("\t0 Process ");

                    var commandId = int.Parse(Console.ReadLine());
                    //Product selectedProduct = null;

                    if (commandId == 1)
                    {
                        //selectedProduct = laptop;
                        //invoker.AddCommand(new AddProductCommand(order, laptop, 1));
                        //invoker.AddCommand(new AddStockCommand(laptop, -1));

                        invoker.ExecuteCommand(new AddProductCommand(order, laptop, 1));
                        invoker.ExecuteCommand(new AddStockCommand(laptop, -1));
                    }
                    else if (commandId == 2)
                    {
                        //selectedProduct = keyboard;
                        invoker.ExecuteCommand(new AddProductCommand(order, keyboard, 1));
                        invoker.ExecuteCommand(new AddStockCommand(laptop, -1));
                    }
 
                    else if (commandId == 3)
                    {
                        //selectedProduct = mouse;
                        invoker.ExecuteCommand(new AddProductCommand(order, mouse, 1));
                        invoker.ExecuteCommand(new AddStockCommand(laptop, -1));
                    }
                    else if ( commandId == 4 )
                    {

                        MacroStorage.Instance.CreateMacro(invoker.GetCommands());
                        invoker.ClearCommnad();
                    }
                    else if (commandId == 5)
                    {
                        ReolayMacro();
                    }
                    else if (commandId == 6)
                    {
                        invoker.Undo();
                        invoker.Undo();

                        var totalQunatity = order.Lines.Sum(l => l.Quantity);  
                        var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Order #{order.Id} updated: Qunatity = {totalQunatity} , Total Price = {totalPrice}");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (commandId ==7)
                    {
                        invoker.Redo();
                        invoker.Redo();

                        var totalQunatity = order.Lines.Sum(l => l.Quantity);
                        var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Order #{order.Id} updated: Qunatity = {totalQunatity} , Total Price = {totalPrice}");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (commandId == 0)
                    {
                        //invoker.ExcludeCommands();
                        var totalQuantity = order.Lines.Sum(x => x.Quantity);
                        var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Order #{order.Id} created: Quantity = {totalQuantity} , tota; Price = {totalPrice}");
                        Console.ForegroundColor = ConsoleColor.White;
                        //break;

                    }
                    // request to objects  =>  AddProduct and  AddStock
                    //order.AddProduct(selectedProduct, 1);

                    //selectedProduct.AddStock(-1);
                }
                Console.WriteLine("--------------------------------------------");
            }

            void ReolayMacro()
            {
                Console.WriteLine("Enter Macro ID: ");
                foreach (var macro in MacroStorage.Instance.GetMacros())
                {
                    Console.WriteLine($"\t{macro.Id}. (commands Count: {macro.Commands.Count()}, Created At: {macro.CreatdAt:yyyy-mm-dd HH:mm:ss}) ");
                }

                var macroId = int.Parse(Console.ReadLine());
                    var selectedMacro = MacroStorage.Instance.GetMacro(macroId);
                    var order = new Order();
                    var invoker = new CommandInvoker();
                    foreach (var command in selectedMacro.Commands)
                    {
                        if (command is AddProductCommand addProductCommand)
                            addProductCommand.Order = order;
                        invoker.AddCommand(command);

                    }
                    invoker.ExcludeCommands();
             

            }
        }

      
    }
}
