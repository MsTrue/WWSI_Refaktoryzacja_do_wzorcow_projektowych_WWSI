using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator
{
    public class LoyalPointsDecorator : PaymentDecorator
    {
        public LoyalPointsDecorator(IPayment payment) : base(payment)
        {

        }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            //Logika punktów
            Console.WriteLine($"Loyalty points added!!! Payment amount: {amount}");

        }
    }
}
