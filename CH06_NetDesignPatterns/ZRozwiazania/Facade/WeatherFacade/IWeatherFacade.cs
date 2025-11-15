using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Facade.WeatherFacade
{
    public interface IWeatherFacade
    {
        Task<WeatherInfo> GetCurrentWeatherAsync(string city);
    }
}
