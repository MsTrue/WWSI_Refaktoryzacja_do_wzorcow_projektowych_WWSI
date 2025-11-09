using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class Transaction
    {
        public bool VerifyDetails()
        {

            return true;
        }
    }

    public class PaymentProcessor
    {
        public void PerformTransaction(Transaction transaction)
        {
           
            if (AreTransactionVerifyDetails(transaction))
            {
                
                CompletePayment(transaction);

                
                UpdateAccountBalance(transaction);

                
                CreateReceipt(transaction);
            }
        }

        private bool AreTransactionVerifyDetails(Transaction transaction)
        {
            return transaction.VerifyDetails();
        }
        private string CompletePayment(Transaction transaction)
        {
            return "Payment completed";
        }
        private string UpdateAccountBalance(Transaction transaction)
        {
            return "Balance updated";
        }
        private string CreateReceipt(Transaction transaction)
        {
            return "Receipt created";
        }
    }
}
