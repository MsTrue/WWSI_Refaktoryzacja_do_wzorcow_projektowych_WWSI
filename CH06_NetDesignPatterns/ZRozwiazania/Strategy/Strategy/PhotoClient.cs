using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Strategy.Strategy
{
    public class PhotoClient
    {
        private IPhotoStrategy _strategy;

        public PhotoClient(IPhotoStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IPhotoStrategy strategy) => _strategy = strategy;

        public Task<IReadOnlyList<PhotoResult>> SearchAsync(string category, int perPage)
       => _strategy.SearchAsync(category, perPage);
    }
}
