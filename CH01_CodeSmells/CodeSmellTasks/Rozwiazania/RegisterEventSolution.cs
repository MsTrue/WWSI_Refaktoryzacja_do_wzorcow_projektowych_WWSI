using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class RegisterEventSolution
    {
        public void RegisterEvent(EventDetails eventDetails)
        {
            Console.WriteLine($"Event: {eventDetails.EventName}, Date: {eventDetails.EventDate}, Location: {eventDetails.Location}");
        }
    }
}

public class EventDetails
{
    public string EventName { get; set; }
    public DateTime EventDate { get; set; }
    public string Location { get; set; }
}
