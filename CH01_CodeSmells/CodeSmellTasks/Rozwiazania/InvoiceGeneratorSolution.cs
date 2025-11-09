using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class InvoiceGeneratorSolution
    {

        public void GenerateInvoice()
        {
            int invoiceNumber = 11;
            using(var pdfWriter = new PdfWriter($"Invoice_{invoiceNumber}.pdf"))
            {
                _pdfWriter.Write("Invoice Content");
            }
           
        }

        public void OtherMethod()
        {
            // Metoda, która nie korzysta z tymczasowych pól
        }
    }
}
