using SantaClausFactoryLive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Command
{
    class Program
    {
        static void Main()
        {
            var factory = new SantaClausFactory();
            var elf = new ElfHelper();


            elf.AddCommand(new CreateToyCommand(factory, "Brown Teddy Bear"));
            elf.AddCommand(new CreateToyCommand(factory, "Purple Teddy Bear"));
            elf.AddCommand(new CreateToyCommand(factory, "Black Teddy Bear"));

            elf.AddCommand(new CreateRodCommand(factory, "Oak Rod"));


            elf.ExecuteAll();


        }
    }
}
