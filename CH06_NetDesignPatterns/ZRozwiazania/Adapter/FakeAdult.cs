using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Adapter
{
    public class FakeAdult : Adult
    {
        private readonly Teenager _teenager;

        public FakeAdult(Teenager teenager)
        {
            _teenager = teenager;
        }

        public override bool IsAdult()
        {
            
            return true;
        }
    }
}
