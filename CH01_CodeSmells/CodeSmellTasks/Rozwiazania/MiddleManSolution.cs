using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class InvoiceRepository
    {

 

        public Invoice GetInvoiceById(int id)
        {
            return new Invoice { Id = id, Amount = 1000};
        }

        public void SaveInvoice(Invoice invoice)
        {
            Console.WriteLine($"Invoice {invoice.Id} saved successfully.");
        }
    }  

public class Invoice
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
}
}
