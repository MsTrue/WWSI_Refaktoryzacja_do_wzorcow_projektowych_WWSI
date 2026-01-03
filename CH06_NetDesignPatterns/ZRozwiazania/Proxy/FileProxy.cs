using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Proxy
{
    public class FileProxy : IFile
    {
        private readonly IFile _realFile;
        private readonly string? _password;

        public FileProxy(IFile realFile, string? password)
        {
            _realFile = realFile;
            _password = password;
        }

        public string Name => _realFile.Name;

        public string? Read(string? password)
        {
           if(_password == null)
            {
                //No password public
                return _realFile.Read(null);
            }

           if(password == _password)
            {
                //Access granted proxy kontroluje dostep.
                return _realFile.Read(null);
            }
           //Access denied
            return null;
        }
    }
}
