using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Observer
{
    public interface IStudentObserver
    {
        void ReceiveResult(string lecturerName, string studentName, int grade);
           
    }
}
