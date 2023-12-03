using CommadandMementoPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadandMementoPattern.Core.Memento
{
    internal class OrderMemento
    {
        private readonly IEnumerable<OrderLine> _lines;

        // immutable => no edit
        public OrderMemento(IEnumerable<OrderLine> lines) {
           _lines = lines;
        }

        public IEnumerable<OrderLine> GetLines() => _lines;

    }
}
