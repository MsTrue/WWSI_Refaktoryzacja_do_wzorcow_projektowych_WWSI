using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Singleton
{
    public sealed class Vault
    {
        private static readonly Vault _instance = new Vault();

        private string _accessKey;

        private readonly object _lock = new object();

        private bool _consumedKey;

       private Vault()
        {
            _accessKey = GenerateAccessKey();
        }
        public static Vault Instance => _instance;

        public string GetAccessKey() => _accessKey;

        private string GenerateAccessKey()
        {
            Random rand = new Random();
            return "KeyAcess" + rand.Next(10000, 99999).ToString();
        }
        public string RetrieveAcessKey()
        {
            lock(_lock)
            {
                if (_consumedKey) throw new InvalidOperationException("Klucz juz został wydany");
                _consumedKey = true;

                var key = _accessKey;
                
                return key;
            }
        }
    }
}
