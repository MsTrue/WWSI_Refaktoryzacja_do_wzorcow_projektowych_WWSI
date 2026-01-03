using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Command
{
    public class ElfHelper
    {

        private readonly List<ICommand> _commands = new();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteAll()
        {
            foreach(var com in _commands)
            {
                com.Execute();
            }
        }
    }
}
