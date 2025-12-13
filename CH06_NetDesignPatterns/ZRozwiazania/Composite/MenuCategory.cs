using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Composite
{
    public sealed class MenuCategory : MenuComponent
    {
        public MenuCategory(string name) : base(name)
        {
        }

        private readonly List<MenuComponent> _children = new();

        public override void Add(MenuComponent component)
        {
            _children.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _children.Remove(component);
        }

        public override IReadOnlyList<MenuComponent> GetChildren() => _children;

        public override void Display()
        {
            Console.WriteLine($"\n[{Name}]");
            foreach (var child in _children)
            {
                child.Display();
            }
        }
    }
}
