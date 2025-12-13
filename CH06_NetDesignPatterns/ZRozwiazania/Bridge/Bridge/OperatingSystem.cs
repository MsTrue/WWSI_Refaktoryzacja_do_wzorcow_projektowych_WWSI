using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Bridge
{
    public abstract class OperatingSystem
    {
        protected IInterface2 _ui;

        protected OperatingSystem(IInterface2 ui)
        {
            _ui = ui;
        }

        public void MenuButton()
        {
            var programs = GetInstalledPrograms();
            _ui.DisplayMenu(programs);
        }

        protected abstract IEnumerable<string> GetInstalledPrograms();
    }
}
