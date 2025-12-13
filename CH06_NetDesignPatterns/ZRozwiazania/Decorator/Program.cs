using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator.Shop;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Decorator
{
    internal class Program
    {
        static void Main()
        {
            var shop = new Shop();


            while (true)
            {
                Console.WriteLine("1. Pay by Card");
                Console.WriteLine("2. Pay by BLIK");
                Console.WriteLine("3. Bank transfer");
                Console.WriteLine("0. Exit");


                Console.Write("Choose: ");
                var choice = Console.ReadLine();

                if (choice == "0") break;


                Console.Write("Enter amount: ");
                if (!decimal.TryParse(Console.ReadLine(), out var amount) || amount <= 0)
                {
                    Console.WriteLine("Invalid amount.");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        shop.Pay(PaymentMethod.Card, amount);
                        break;
                    case "2":
                        shop.Pay(PaymentMethod.Blik, amount);
                        break;
                    case "3":
                        shop.Pay(PaymentMethod.BankTransfer, amount);
                        break;
                    default:
                        Console.WriteLine("Try again....");
                        break;
                }
            }
        }
    }
}
