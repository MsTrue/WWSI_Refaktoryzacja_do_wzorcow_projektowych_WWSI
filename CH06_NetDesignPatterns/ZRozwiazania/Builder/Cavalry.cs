using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public class Cavalry : IWarrior
    {
        public string Profession { get; private set; } = "Cavalry";


        public string Weapon { get; internal set; } = "a spear on horseback";
        public void Equip(string weapon) => Weapon = weapon;
        public void Attack()
        {
            Console.WriteLine($"I'm a {Profession}! I attack with {Weapon}!");
        }
    }
}
