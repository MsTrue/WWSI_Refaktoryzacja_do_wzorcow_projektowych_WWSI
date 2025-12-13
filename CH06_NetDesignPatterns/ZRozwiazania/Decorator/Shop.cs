using RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania;
using RefactoringToDesignPatterns.CH01_CodeSmells.Solutions;
using RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator
{
    public class Shop
    {
        public enum PaymentMethod
        {
            Card,
            Blik,
            BankTransfer
        }
        public void Pay(PaymentMethod method, decimal amount)
        {
            IPayment payment;
            switch (method)
            {
                case PaymentMethod.Card:
                    payment = BuildCardPaymentPipeline();
                    break;

                case PaymentMethod.Blik:
                    payment = new BlikPayment();
                    break;

                case PaymentMethod.BankTransfer:
                    payment = new BankTransferPayment();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(method));
            }
        }
        private IPayment BuildCardPaymentPipeline()
        {
            IPayment payment = new CardPayment();

           
            payment = new SmsNotificationDecorator(payment);
            payment = new LoyalPointsDecorator(payment);
            payment = new RedirectHomePageDecorator(payment);

            return payment;
        }
    }
}

