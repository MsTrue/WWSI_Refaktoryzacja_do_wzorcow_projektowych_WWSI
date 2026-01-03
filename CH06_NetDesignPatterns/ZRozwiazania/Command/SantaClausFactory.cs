using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Command
{
    public class SantaClausFactory
    {

        private readonly List<string> _items = new();

        public IReadOnlyList<string> ProducedItems => _items;


        public void CreateToy(string toy)
        {
            var item = $"Toy: {toy}";
            Console.WriteLine("Toy creation....");
            _items.Add(item);
        }

        public void CreateRod(string rod)
        {
            var item = $"Rod: {rod}";
            Console.WriteLine("Rod cretion....");
            _items.Add(item);
        }
    }
}
