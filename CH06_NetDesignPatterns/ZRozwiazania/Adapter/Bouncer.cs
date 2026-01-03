using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Adapter
{
    public class Bouncer
    {
        public void CheckEntry(Adult adult)
        {
            if (adult.IsAdult())
            {
                Console.WriteLine("Come on in...");
            }else
            {
                Console.WriteLine("Go away...");
            }
        }
    }
}
