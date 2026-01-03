using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Flyweight
{
    public class TextureFactory
    {
        private readonly Dictionary<string, Texture> _cache = new();

        public Texture GetTexture(string filePath)
        {
            if (_cache.TryGetValue(filePath, out var texture))
                return texture;

            texture = new Texture(filePath);
            _cache[filePath] = texture;
            return texture;
        }

        public void PrintStats()
        {
            long bytes = 0;
            foreach (var t in _cache.Values)
            {
                bytes += t.Data.LongLength;
            }
        }
    }
}
