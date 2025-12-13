using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Composite
{
    internal class Program
    {

        static void Main()
        {

            var root = new MenuCategory("Restaurant menu");


            var appetizers = new MenuCategory("Appetizers");
            appetizers.Add(new MenuItem("Bruschetta", 18.50m));
            appetizers.Add(new MenuItem("Soup", 10.50m));


            var mains = new MenuCategory("Main");

            var pasta = new MenuCategory("Pasta");
            pasta.Add(new MenuItem("Carbonara", 34.90m));
            pasta.Add(new MenuItem("Bolognese", 32.90m));

            var pizza = new MenuCategory("Pizza");

            pizza.Add(new MenuItem("Hawaii", 32.50m));
            pizza.Add(new MenuItem("Peperonii", 31.00m));


            var desserts = new MenuCategory("Desserts");
            desserts.Add(new MenuItem("Cheesecake", 19.90m));
            desserts.Add(new MenuItem("Ice Cream", 14.00m));

            mains.Add(pasta);
            mains.Add(pizza);

            root.Add(appetizers);
            root.Add(mains);
            root.Add(desserts);


            root.Display();
        }
    }
}
