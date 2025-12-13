using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator
{
    public class BlikPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Blik payment amount:{amount}");
        }
    }
}
