using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Bridge
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IInterface2 windowsUI = new GraphicInterface();
            OperatingSystem windows = new WindowsSystem(windowsUI);
            windows.MenuButton();

            IInterface2 linuxGui = new GraphicInterface();
            OperatingSystem linuxWithGui = new LinuxSystem(linuxGui);
            linuxWithGui.MenuButton();


            IInterface2 linuxCli = new ConsoleInterface();
            OperatingSystem linuxWithCli = new LinuxSystem(linuxCli);
            linuxWithCli.MenuButton();


        }
    }


}
