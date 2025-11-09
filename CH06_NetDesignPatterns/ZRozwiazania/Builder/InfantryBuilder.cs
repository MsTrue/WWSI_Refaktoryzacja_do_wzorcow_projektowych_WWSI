

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    public class InfantryBuilder : WarriorBuilder
    {
        public override void Enlist()
        {
            _warrior = new Infantry();
        }

        public override void EquipWeapon()
        {
            string[] weapons =
            {
                "a short sword and shield",
                "a longsword",
                "dual daggers"
            };
            string selected = weapons[_rnd.Next(weapons.Length)];
            
            _warrior.Equip(selected);
            
        }

        public override void Train()
        {
            Console.WriteLine("Training.... Infantry");
        }
    }
}
