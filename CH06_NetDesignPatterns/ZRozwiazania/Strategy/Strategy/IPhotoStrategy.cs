using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Strategy.Strategy
{
    public interface IPhotoStrategy
    {
        Task<IReadOnlyList<PhotoResult>> SearchAsync(string category, int perPage);
    }

    public record PhotoResult(string Title, string url, string imageUrl);
}
