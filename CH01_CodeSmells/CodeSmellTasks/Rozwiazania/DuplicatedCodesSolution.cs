using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class DuplicatedCodesSolution
    {
       
        public void LogError(string message, DateTime timestamp)
        {
            
            Console.WriteLine(FormatMessage("ERROR", message, timestamp));
        }

        public void LogWarning(string message, DateTime timestamp)
        {

           
            Console.WriteLine(FormatMessage("WARNING", message, timestamp));
        }

         
        public string FormatMessage(string level, string message, DateTime timestamp)
        {
            string formattedTimestamp = timestamp.ToString("yyyy-MM-dd HH:mm:ss");

            return $"{level} [{formattedTimestamp}] {message}";
        }
    }
}
