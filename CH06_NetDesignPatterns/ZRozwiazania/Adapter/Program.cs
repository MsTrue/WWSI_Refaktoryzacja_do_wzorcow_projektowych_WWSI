using PartyAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Adapter
{
    class Program
    {
        static void Main()
        {
            var bouncer = new Bouncer();

            var krzys = new Teenager("Krzys", 17);

            
            //bouncer.CheckEntry(krzys); -> nie wykona sie

           
            Console.WriteLine("Krzys with FakeAdult adapter:");
            Adult fakeAdult = new FakeAdult(krzys);
            bouncer.CheckEntry(fakeAdult);
        }
    }
}
