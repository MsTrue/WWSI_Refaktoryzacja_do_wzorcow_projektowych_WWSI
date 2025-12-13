using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator
{
    public class PaymentDecorator : IPayment
    {
        protected IPayment _payment;
        public PaymentDecorator(IPayment payment)
        {
            _payment = payment;
        }
        public virtual void Pay(decimal amount)
        {
            _payment.Pay(amount);
        }
    }
}
