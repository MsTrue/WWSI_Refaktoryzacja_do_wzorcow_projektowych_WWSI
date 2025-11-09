using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class ProductManager
    {
        public void RegisterProduct(ProductDetails product)
        {
            Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }

    public class ProductDetails
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
