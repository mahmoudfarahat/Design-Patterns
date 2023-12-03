using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadPattern.Core.Commands
{
    internal class AddProductCommand : ICommand
    {
        public Order Order { get; set; }
        private readonly Product product;
        private readonly double quantity;

        public AddProductCommand(Order order , Product product , double quantity)
        {
            Order = order;
            this.product = product;
            this.quantity = quantity;
        }

        public void Execute()
        {
              Order.AddProduct(this.product , this.quantity);
        }

        public void Undo()
        {
            Order.RemoveProductAt(Order.Lines.Count() - 1);
        }
    }
}
