using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Factory
{
    class Program
    {
        static void Main()
        {
            var garrison = new Garrison();


            Warrior[] warriors = new Warrior[10];

            for (int i = 0; i < 3; i++)
                warriors[i] = garrison.Train("Infantry");

            for (int i = 0; i < 6; i++)
                warriors[i] = garrison.Train("Cavalry");

            for (int i = 0; i < 6; i++)
                warriors[i] = garrison.Train("Archer");

            foreach (var w in warriors)
            {
                w.Attack();
            }
        }
    }
}
