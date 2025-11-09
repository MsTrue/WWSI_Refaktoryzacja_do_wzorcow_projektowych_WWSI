using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Factory
{
    public class Archer : Warrior
    {
        public Archer()
        {
            Profession = "Archer";
            Weapon = "bow";
        }
        
    }
}
