using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    class RefusedBequestSolution
    {

        public interface IEmployee
        {
            public void Work();
            public void AttendMeeting();

        public interface IManager
        {
                public void AskForReport();
                public void AskForCoffee();
        }
        public class BasicEmployee
        {
            public string Name { get; set; }
            public string Position { get; set; }
        }
      public class Employee : BasicEmployee, IEmployee
        {
            public void Work() { /* Implementacja */ }
            public void AttendMeeting() { /* Implementacja */ }

        }

        public class Manager : BasicEmployee, IEmployee, IManager
            {
                public void ManageTeam() { /* Implementacja */ }
                public void Work() { /* Implementacja */ }
                public void AttendMeeting() { /* Implementacja */ }
                public void AskForReport() { /* Implementacja */ }
                public void AskForCoffee() { /* Implementacja */ }
            }

        }
}
