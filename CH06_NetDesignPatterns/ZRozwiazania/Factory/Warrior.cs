using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Factory
{
    public abstract class Warrior
    {
        public string Profession { get; protected set; }
        public string Weapon { get; protected set; }
        public virtual void Attack()
        {
            Console.WriteLine($"I'm a {Profession}! I attack with {Weapon}!");
        }
    }
}
