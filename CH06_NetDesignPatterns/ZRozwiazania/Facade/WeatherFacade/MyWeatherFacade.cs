

using System.Text.Json;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Facade
{
    public class MyWeatherFacade : Facade.WeatherFacade.IWeatherFacade
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public MyWeatherFacade(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<WeatherInfo> GetCurrentWeatherAsync(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City name cannot be empty.");

            //https://openweathermap.org/current#name

            var url =
                $"https://api.openweathermap.org/data/2.5/weather?q={Uri.EscapeDataString(city)}&appid={_apiKey}&units=metric";

            using var response = await _httpClient.GetAsync(url);



            if (!response.IsSuccessStatusCode)
            {

                throw new Exception("Something went wrong!");
            }

            var json = await response.Content.ReadAsStringAsync();


            using var doc = JsonDocument.Parse(json);

            var root = doc.RootElement;
            //https://openweathermap.org/current#example_JSON

            var temperature = root.GetProperty("main").GetProperty("temp").GetDouble();
            var description = root.GetProperty("weather")[0].GetProperty("description").GetString();
            var name = root.GetProperty("name").GetString();


            return new WeatherInfo
            {
                CityName = name,
                Temperature = temperature,
                Description = description
            };
        }
    }
}
