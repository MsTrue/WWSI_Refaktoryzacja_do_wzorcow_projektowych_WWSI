using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public abstract class WarriorBuilder
    {
        protected IWarrior _warrior;
        protected static readonly Random _rnd = new Random();

        public abstract void Enlist();

        public abstract void EquipWeapon();

        public abstract void Train();

        public virtual IWarrior Build() => _warrior;
    }
}
