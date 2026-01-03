using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Proxy
{
    public class PublicFile : IFile
    {
        public string Name { get; }
        private readonly string _content;

        public PublicFile(string name, string content)
        {
            Name = name;
            _content = content;
        }

        public string? Read(string? password)
        {
            return _content;
        }
    }
}
