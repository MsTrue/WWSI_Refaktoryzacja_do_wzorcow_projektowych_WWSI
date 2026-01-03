using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Flyweight
{
    public class Texture
    {
        public string FilePath { get; }
        public byte[] Data { get;}

        public Texture(string filePath)
        {
            FilePath = filePath;

            //Symulacja wczytania z pliku
            Data = LoadFromDisk(filePath);
           
        }
        private static byte[] LoadFromDisk(string filePath)
        {
           
            return new byte[1024 * 1024];

    }
}
