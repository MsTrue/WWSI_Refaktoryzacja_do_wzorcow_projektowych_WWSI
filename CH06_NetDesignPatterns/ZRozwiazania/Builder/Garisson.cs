using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public class Garisson
    {
        public IWarrior TrainWarrior(WarriorBuilder builder)
        {
            builder.Enlist();
            builder.EquipWeapon();
            builder.Train();

            return builder.Build();
        }

        
    }
}
