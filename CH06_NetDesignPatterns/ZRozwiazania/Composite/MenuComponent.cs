using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Composite
{
   public abstract class MenuComponent
    {

        public string Name { get; set; }

        protected MenuComponent(string name)
        {
            Name = name;
        }

        public virtual void Add(MenuComponent component) =>
            throw new NotSupportedException("Can't add to a leaf");

        public virtual void Remove(MenuComponent component) =>
            throw new NotSupportedException("Can't remove from a leaf");


        public virtual IReadOnlyList<MenuComponent> GetChildren() =>
            Array.Empty<MenuComponent>();

        public abstract void Display();

       
    }
}
