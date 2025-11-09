using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class Payment
    {
        private readonly IPaymentFeeStrategy _paymentFeeStrategy;

        public Payment(IPaymentFeeStrategy paymentFeeStrategy)
        {
            _paymentFeeStrategy = paymentFeeStrategy;
        }

        public string PaymentMethod { get; set; }

        public decimal DeterminePaymentFee(decimal amount)
        {
            return _paymentFeeStrategy.DeterminePaymentFee(amount);
        }
    }

    public interface IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount);
    }
    public class CreditCardFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.02m;
        }
    }
    public class PayPalFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.03m;
        }
    }
    public class BankTransferFeeStrategy : IPaymentFeeStrategy
    {
        public decimal DeterminePaymentFee(decimal amount)
        {
            return amount * 0.01m;
        }
    }
}
