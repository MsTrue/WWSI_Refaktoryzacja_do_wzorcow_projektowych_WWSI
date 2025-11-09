using SingletonVault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var vault1 = Vault.Instance;

            Console.WriteLine(vault1.GetAccessKey());

            try
            {
                Console.WriteLine(vault1.GetAccessKey());
            } catch(InvalidOperationException ex)
            {
               Console.WriteLine(ex.Message);
            }
           

           
        }
    }
}
