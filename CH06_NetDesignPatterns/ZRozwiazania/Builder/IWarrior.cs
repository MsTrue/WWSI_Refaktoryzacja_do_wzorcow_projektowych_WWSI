using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public interface IWarrior
    {
        string Profession { get; }
        string Weapon { get; }
        void Equip(string weapon);
        void Attack();
    }
}
