using RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Facade;
namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.FacadeApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string apiKey = "c89ad9f8d48d6c698d0493eb8a5827ae"; 

            using var httpClient = new HttpClient();
            var weatherFacade = new MyWeatherFacade(httpClient, apiKey);

            while (true)
            {
                Console.Write("Enter city name: ");
                var city = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(city))
                {
                    Console.WriteLine("City required, program stops");
                    break;
                }

                try
                {
                    var info = await weatherFacade.GetCurrentWeatherAsync(city);

                    if (info == null)
                    {
                        Console.WriteLine("No weather for this city. Check name and try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Weather in {info.CityName}:");
                        Console.WriteLine($"Temperature: {info.Temperature}");
                        Console.WriteLine($"Description: {info.Description}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while getting weather: {ex.Message}");
                }
            }
        }
    }
}