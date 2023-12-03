using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadandMementoPattern.Core.Memento
{
    internal class Caretaker
    {
        private List<OrderMemento> _mementos = new();
        public int AddMemento(OrderMemento memento)
        {
            _mementos.Add(memento);
            return _mementos.Count-1;
        }

        public OrderMemento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
