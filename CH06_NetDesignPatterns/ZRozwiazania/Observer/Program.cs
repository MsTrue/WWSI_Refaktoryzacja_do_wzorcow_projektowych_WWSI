using RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Observer
{
    class Program
    {
        static void Main()
        {
            var lecturer = new Lecturer("Nowak");

            var student1 = new Student("Asia");
            var student2 = new Student("Kasia");
            var student3 = new Student("Basia");


            lecturer.Subscribe(student1);
            lecturer.Subscribe(student2);
            lecturer.Subscribe(student3);

            //wyniki
            lecturer.GiveResults();

            //przyklad usuniecia z notyfikacji o wynikach
            lecturer.Unsubscribe(student2);
        }
    }

    }
