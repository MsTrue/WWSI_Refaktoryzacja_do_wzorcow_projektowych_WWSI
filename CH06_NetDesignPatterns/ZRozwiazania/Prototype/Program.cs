using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Prototype
{
     class Program
    {
        static void Main()
        {
            var baseOrk = new Ork
            {
                Id = Guid.NewGuid(),
                Name = "Name1",
                Strength = 10,
                Agility = 10
            };

            var rnd = new Random();
            var orcs = new List<Ork>();

            for (int i = 1; i <+ 8; i++)
            {
                var clone = baseOrk.Clone();

                clone.Id = Guid.NewGuid();
                clone.Name = $"{baseOrk.Name.Substring(0, 3)} + {i}";

                int randomStrength = rnd.Next(1, 25);
                clone.Strength = randomStrength;


                orcs.Add(clone);
            }

            Ork.ListOrks(orcs);
        }
        }
    }
