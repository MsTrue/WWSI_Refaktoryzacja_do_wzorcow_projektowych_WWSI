using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{
    class MessageChainsSolution
    {
        
        public class Car
        {
            
            public string getCylinderSize()
            {
                Engine engine = new Engine();
                return engine.GetCylinder().GetSize();
            }
        }

        public class Engine
        {
            public Cylinder GetCylinder()
            {
                return new Cylinder();
            }
        }

        public class Cylinder
        {
            public string GetSize()
            {
                return "2.0L";
            }
        }

        // Przykład wywołania
        Car car = new Car();
        string cylinderSize = car.getCylinderSize();

    }
}
