using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class Customer
    {
        public string Name { get; set; }
    }

    public class OrderService
    {
        public void CreateOrder(Customer customer)
        {
            Console.WriteLine($"Order created for customer {customer.Name}.");
            SaveOrder();
        }

        private void SaveOrder()
        {
            Console.WriteLine("Order saved.");
        }
    }
}
