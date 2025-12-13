using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator
{
    public class RedirectHomePageDecorator : PaymentDecorator
    {
        public RedirectHomePageDecorator(IPayment payment) : base(payment)
        {

        }

        public override void Pay(decimal amount)
        {
            base.Pay(amount);
            
            Console.WriteLine($"Redirect to homepage....");

        }
    }
}
