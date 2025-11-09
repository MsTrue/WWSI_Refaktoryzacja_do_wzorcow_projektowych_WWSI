using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }


        public string GetFormattedPrice()
        {
            return Price.ToString();
        }

        public bool IsInStock()
        {
            return StockQuantity > 0;
        }
    }
}
