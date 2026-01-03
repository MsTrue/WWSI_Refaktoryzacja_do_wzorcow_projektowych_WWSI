using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Command
{
    public class CreateToyCommand : ICommand
    {
        private readonly SantaClausFactory _factory;
        private readonly string _toy;

        public CreateToyCommand(SantaClausFactory factory, string toy)
        {
            _factory = factory;
            _toy = toy;
        }

        public void Execute()
        {
            _factory.CreateToy(_toy);
        }

        
    }
}
