using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
   

    public class MessagingService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
        public void LogNotification(string message)
        {
            Console.WriteLine($"Notification logged: {message}");
        }
    }
}
