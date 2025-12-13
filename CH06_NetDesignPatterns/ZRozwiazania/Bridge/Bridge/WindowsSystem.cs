using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Bridge
{
    public class WindowsSystem : OperatingSystem
    {

        public WindowsSystem(IInterface2 ui) : base(ui)
        {
            
        }
        protected override IEnumerable<string> GetInstalledPrograms()
        {
            return new List<string>
           {
               "Paint",
               "Calculator",
               "Microsoft Word",
               "Microsoft Excel"
           };
        }
    }
}
