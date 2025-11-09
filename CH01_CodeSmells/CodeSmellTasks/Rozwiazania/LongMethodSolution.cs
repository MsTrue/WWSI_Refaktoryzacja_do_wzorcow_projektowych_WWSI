using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class GradeBook
    {
        private int _grade;
        private bool _isFinalized;

        public int Grade => _grade;
        public bool isFinalized => _isFinalized;

        public void SetGrade(int grade)
        {
            _grade = grade;
        }
        public void Finalize()
        {
            _isFinalized = true;
        }
    }

    public class Teacher2
    {
        public void FinalizeGrades(GradeBook gradeBook)
        {
            gradeBook.SetGrade(90);
            gradeBook.Finalize();
        }
    }
}
