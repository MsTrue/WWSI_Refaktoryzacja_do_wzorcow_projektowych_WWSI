using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Flyweight
{
    class Program
    {
        static void Main()
        {
            static void Main()
            {
                var textureFactory = new TextureFactory();

                var gameObjects = new List<GameObject>
                {
                new GameObject("Warrior",   10,  5, textureFactory.GetTexture("textures/warrior.png")),
                new GameObject("Enemy1", 20,  7, textureFactory.GetTexture("textures/enemy.png")),
                new GameObject("Enemy2", 25,  9, textureFactory.GetTexture("textures/enemy.png")),
                new GameObject("Tree1",   5, 12, textureFactory.GetTexture("textures/tree.png")),
                new GameObject("Tree2",   7, 15, textureFactory.GetTexture("textures/tree.png")),
                new GameObject("Tree3",  12, 16, textureFactory.GetTexture("textures/tree.png")),
                new GameObject("Warrior2",  11,  6, textureFactory.GetTexture("textures/warrior.png")),
                 };

               //Render
                foreach (var obj in gameObjects)
                    obj.Render();


                textureFactory.PrintStats();

                Console.WriteLine($"Enemy1 texture == Enemy2 texture: {ReferenceEquals(gameObjects[1].Texture, gameObjects[2].Texture)}");
                Console.WriteLine($"Tree1 texture == Tree2 texture:   {ReferenceEquals(gameObjects[3].Texture, gameObjects[4].Texture)}");
                Console.WriteLine($"Warrior texture == Warrior2 texture:    {ReferenceEquals(gameObjects[0].Texture, gameObjects[6].Texture)}");
            }
        }
    }
}
