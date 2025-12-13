using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Composite
{
    public sealed class MenuItem : MenuComponent
    {

        public decimal Price { get; set; }

       

        public MenuItem(string name, decimal price)
           : base(name)
        {
            Price = price;
            
        }

        public override void Display()
        {
            Console.WriteLine($"{Name} ({Price:0.00} PLN)");
        }
    }
}
