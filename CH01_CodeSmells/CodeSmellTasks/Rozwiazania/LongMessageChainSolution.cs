using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    public class School
    {
        public Classroom GetClassroom()
        {
            return new Classroom();
        }

        public void GetTeachherName()
        {
            var classroom = GetClassroom().GetTeacher().GetName();
        }
    }

    public class Classroom
    {
        public Teacher GetTeacher()
        {
            return new Teacher();
        }
    }

    public class Teacher
    {
        public string GetName()
        {
            return "John Smith";
        }
}

// Przykład wywołania
      //  School school = new School();
        //string teacherName = school.GetTeachherName();
    }
