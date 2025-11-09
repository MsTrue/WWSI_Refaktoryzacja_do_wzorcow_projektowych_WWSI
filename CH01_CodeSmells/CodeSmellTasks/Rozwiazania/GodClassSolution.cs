using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class AdminPanel
    {

        private readonly UserManager _userManager = new UserManager();
        private readonly SystemConfigurator _systemConfigurator = new SystemConfigurator();
        private readonly LogRegisterer _logRegisterer = new LogRegisterer();
        private readonly SystemReportGenerator _systemReportGenerator = new SystemReportGenerator();
     }
    public class UserManager
    {
        public void ManageUsers()
        {
            Console.WriteLine("Managing users.");
        }
    }
    public class SystemConfigurator
    {
        public void ConfigureSystem()
        {
            Console.WriteLine("Configuring system.");
        }
    }
    public class LogRegisterer
    {
        public void RegisterLog(string log)
        {
            Console.WriteLine($"Log: {log}");
        }
    }
    public class SystemReportGenerator
    {
        public void GenerateSystemReport()
        {
            Console.WriteLine("System report generated.");
        }
    }
}
