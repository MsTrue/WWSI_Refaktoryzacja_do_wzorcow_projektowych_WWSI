using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Strategy.Strategy
{
    public class PexelsStrategy : IPhotoStrategy
    {
        private readonly HttpClient _http;
        private readonly string _apiKey;


        public PexelsStrategy(HttpClient http, string apiKey)
        {
            _http = http;
            _apiKey = apiKey;
        }

        public async Task<IReadOnlyList<PhotoResult>> SearchAsync(string category, int perPage)
        {
            var url = $"https://api.pexels.com/v1/search?query={category}&per_page={perPage}";

            using var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", _apiKey);

            using var response = await _http.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode) throw new InvalidOperationException("Something went wrong....");


                var results = new List<PhotoResult>();
                using var doc = JsonDocument.Parse(body);

            if (!doc.RootElement.TryGetProperty("photos", out var photos) || photos.ValueKind != JsonValueKind.Array)
                return results;


            foreach (var p in photos.EnumerateArray())
            {
                var pageUrl = p.GetProperty("url").GetString();

                
                var src = p.GetProperty("src");
                var imageUrl = src.TryGetProperty("medium", out var medium).ToString();
                   

                results.Add(new PhotoResult(
                    Title: category,
                    url: pageUrl,
                    imageUrl: imageUrl
                ));
            }

            return results;
        }
    }
}
