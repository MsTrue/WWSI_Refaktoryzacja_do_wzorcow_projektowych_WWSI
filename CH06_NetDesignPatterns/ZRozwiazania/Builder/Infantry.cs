using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public class Infantry : IWarrior
    {
        public string Profession { get; private set; } = "Infantry";


        public string Weapon { get; protected internal set; } = "a sword";
        public void Equip(string weapon) => Weapon = weapon;
        public void Attack()
        {
            Console.WriteLine($"I'm a {Profession}! I attack with {Weapon}!");
        }

       
    }
}
