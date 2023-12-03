using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadPattern.Core.Commands
{
    public class MacroStorage
    {
        // singletion to save it in database or any storage 
        private MacroStorage()
        {

        }

        public static MacroStorage Instance { get; } = new();

        private List<Macro> _macros = new();

        public void CreateMacro(IEnumerable<ICommand> commands)
        {
            var macro = new Macro(_macros.Count + 1, commands.ToList());
            _macros.Add(macro);
            Console.WriteLine($"Macro #{macro.Id} saved.");
            Console.ForegroundColor = ConsoleColor.White;
        }

       public IEnumerable<Macro> GetMacros() => _macros.AsReadOnly();

        public Macro GetMacro(int id)
        {
            return _macros.First(x => x.Id == id);
        }
    }
}
