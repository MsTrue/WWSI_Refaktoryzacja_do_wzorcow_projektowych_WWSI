using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Proxy
{
    public interface IFile
    {
         string Name { get; }
         string? Read(string? password);
    }
}
