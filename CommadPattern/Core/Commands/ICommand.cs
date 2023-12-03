using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadPattern.Core.Commands
{
    public interface ICommand
    {
        void Execute();

        void Undo();

      
    }
}
