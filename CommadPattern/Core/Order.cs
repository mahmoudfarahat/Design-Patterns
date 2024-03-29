﻿using CommadandMementoPattern.Core.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadandMementoPattern.Core
{
    internal class Order
    {
        // orignator = object which i keep its state 
        public int Id { get; } = Random.Shared.Next(0, 1000);

        // domain driven
        private List<OrderLine> _lines = new();
        public IEnumerable<OrderLine> Lines => _lines.AsReadOnly();

        public void AddProduct(Product product, double quantity)
        {
            _lines.Add(new OrderLine { ProductId = product.Id , UnitPrice = product.UnitPrice , Quantity = quantity });

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Product `{product.Name}` added, Order now contains {_lines.Count} Products");

            Console.ForegroundColor = ConsoleColor.White;



        }

        internal   void RemoveProductAt(int index)
        {
            _lines.RemoveAt(index);
        }


        public OrderMemento SaveStateToMemento()
        {
            return new OrderMemento(_lines.ToArray());
        }


        public void RestoreStateFromMemento(OrderMemento memento)
        {
            _lines = new List<OrderLine>(memento.GetLines());
        }
    }
}
