using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH01_CodeSmells.CodeSmellTasks.Rozwiazania
{

    public interface ILogger
    {
        public  void LogMessage();
    }
    public interface IExporter
    {
        public void ExportData();
    }
   /* public class BaseLogger
    {
        public virtual void LogMessage() { *//* Implementacja *//* }
    }*/

    public class FileLogger : ILogger
    {
        public void LogMessage() { /* Implementacja dla pliku */ }
    }

    public class DatabaseLogger : ILogger
    {
        public  void LogMessage() { /* Implementacja dla bazy danych */ }
    }

   /* public class BaseExporter
    {
        public virtual void ExportData() { *//* Implementacja *//* }
    }*/

    public class XmlExporter : IExporter
    {
        public  void ExportData() { /* Implementacja dla XML */ }
    }

    public class JsonExporter : IExporter
    {
        public  void ExportData() { /* Implementacja dla JSON */ }
    }
}
