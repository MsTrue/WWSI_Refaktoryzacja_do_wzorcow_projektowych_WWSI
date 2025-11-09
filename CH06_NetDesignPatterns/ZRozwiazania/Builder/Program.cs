

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Builder
{
    class Program
    {
        static void Main()
        {
            var garisson = new Garisson();
            var army = new List<IWarrior>();

           
            army.Add(garisson.TrainWarrior(new InfantryBuilder()));
            army.Add(garisson.TrainWarrior(new InfantryBuilder()));

            army.Add(garisson.TrainWarrior(new CavalryBuilder()));
            army.Add(garisson.TrainWarrior(new CavalryBuilder()));

            army.Add(garisson.TrainWarrior(new ArcherBuilder()));
            army.Add(garisson.TrainWarrior(new ArcherBuilder()));

            foreach (var w in army)
                w.Attack();
        }
    }
}
