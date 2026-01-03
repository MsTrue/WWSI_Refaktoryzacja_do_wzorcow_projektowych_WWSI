using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Observer
{
    public class Student : IStudentObserver
    {
        public Student(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void ReceiveResult(string lecturerName, string studentName, int grade)
        {
            if (!string.Equals(Name, studentName))
                return;

            Console.WriteLine($"Student: {Name} Result from {lecturerName}: {grade}");
        }
    }
}
