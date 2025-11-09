using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public class ArcherBuilder : WarriorBuilder
    {
        public override void Enlist()
        {
            _warrior = new Archer();
        }

        public override void EquipWeapon()
        {
            string[] weapons =
           {
                "a longbow",
                "a crossbow",
                "a hunting bow"
            };

            string selected = weapons[_rnd.Next(weapons.Length)];
            _warrior.Equip(selected);


        }

        public override void Train()
        {
            Console.WriteLine("Training.... Archer");
        }
    }
}
