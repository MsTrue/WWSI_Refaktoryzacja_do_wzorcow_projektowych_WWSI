using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Bridge
{
    public class ConsoleInterface : IInterface2
    {
        public void DisplayMenu(IEnumerable<string> programs)
        {
            Console.WriteLine("Console Menu!");

            foreach (var p in programs)
            {
                Console.WriteLine($"{p}");
            }
        }
    }
}
