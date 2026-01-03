using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Flyweight
{
    public class GameObject
    {
      

        public string Name { get; }
        public int X { get;  }
        public int Y { get;  }
        public Texture Texture { get; }

        public GameObject(string name, int x, int y, Texture texture)
        {
            Name = name;
            X = x;
            Y = y;
            Texture = texture;
        }

        public void Render()
        {
            Console.WriteLine($"Render {Name}, points: {X}, {Y} texture: {Texture.FilePath}, {Texture.GetHashCode()}");
        }

    }
}
