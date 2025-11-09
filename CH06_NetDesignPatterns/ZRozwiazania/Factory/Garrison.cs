using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Factory
{
    public class Garrison
    {
        public Warrior Train(string profession)
        {
            switch (profession.ToLower())
            {
                case "infantry": return new Infantry();
                case "archer" : return new Archer();
                case "cavalry" : return new Cavalry();
                default: throw new ArgumentException("Unknown profession");
            }
        }
    }
}
