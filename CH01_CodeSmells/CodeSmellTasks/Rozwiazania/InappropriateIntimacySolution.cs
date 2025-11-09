using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class Course
    {
        private int _credits;
        private bool _isCompleted;

        public int Credits
        {
            get { return _credits; }
           
        }
        public bool IsCompleted
        {
            get { return _isCompleted; }
           
        }
        public void SetCredits(int credits)
        {
            _credits = Credits;
        }
        public void Complete()
        {
            _isCompleted = true;
        }
    }

    public class Student
    {
        public void CompleteCourse(Course course)
        {
            course.SetCredits(3); // Bezpośrednie ustawianie prywatnych pól
            course.Complete(); // Bezpośrednie ustawianie prywatnych pól
        }
    }
}
