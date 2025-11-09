using Newtonsoft.Json;


namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Prototype
{
    public class Ork
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }



        public Ork Clone()
        {
            var json = JsonConvert.SerializeObject(this);

            return JsonConvert.DeserializeObject<Ork>(json)!;
        }

        public static void ListOrks(IEnumerable<Ork> orks)
        {
           
            foreach (var ork in orks)
            {
                Console.WriteLine($"{ork.Name}, STR={ork.Strength}");
            }
        }
    }
}
