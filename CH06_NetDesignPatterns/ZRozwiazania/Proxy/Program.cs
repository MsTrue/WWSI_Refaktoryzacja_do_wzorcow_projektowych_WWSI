using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Proxy
{
    class Program
    {
        static void Main()
        {
            var files = new List<IFile>
             {
                new FileProxy(new PublicFile("Public info.txt", "This is public content."), null),
                new FileProxy(new RestrictedFile("Secret plan.txt", "TOP SECRET"), password: "sf1234"),
                new FileProxy(new RestrictedFile("HR data.txt", "Salaries."), password: "sf3212"),
            };

            // wybieranie pliku
            //....
        }
    }
}
