using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Observer
{
    public class Lecturer
    {
        public string Name { get; set; }

        private readonly List<IStudentObserver> _observers = new();
        private readonly Dictionary<string, int> _grades = new();

        public Lecturer(string name)
        {
            Name = name;
        }
        public void Subscribe(IStudentObserver observer) => _observers.Add(observer);

        public void Unsubscribe(IStudentObserver observer) => _observers.Remove(observer);

        public void SetGrade(string studentName, int grade)
        {
            _grades[studentName] = grade;
        }

        public void GiveResults()
        {
            foreach (var (studentName, grade) in _grades)
            {
                Notify(studentName, grade);
            }
        }
        private void Notify(string studentName, int grade)
        {
            foreach (var obs in _observers)
                obs.ReceiveResult(Name, studentName, grade);
        }
    }
}
