using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Strategy.Strategy
{
    public class PixabayStrategy : IPhotoStrategy
    {
        private readonly HttpClient _http;
        private readonly string _apiKey;
       

        public PixabayStrategy(HttpClient http, string apiKey)
        {
            _http = http;
            _apiKey = apiKey;
        }

        public async Task<IReadOnlyList<PhotoResult>> SearchAsync(string category, int perPage)
        {
            var url = $"https://pixabay.com/api/?key={_apiKey}&q={category}&image_type=photo&per_page={perPage}";

            using var response = await _http.GetAsync(url);

            var body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new InvalidOperationException("Something went wrong....");


            var results = new List<PhotoResult>();
            using var doc = JsonDocument.Parse(body);

            if (!doc.RootElement.TryGetProperty("hits", out var hits) || hits.ValueKind != JsonValueKind.Array)
                return results;

            foreach (var h in hits.EnumerateArray())
            {
                var tags = h.TryGetProperty("tags", out var tagsEl) ? tagsEl.GetString() : category;
                var pageUrl = h.TryGetProperty("pageURL", out var pageEl) ? pageEl.GetString() : "";
                var imageUrl = h.TryGetProperty("webformatURL", out var imgEl) ? imgEl.GetString() : "";

                results.Add(new PhotoResult(
                    Title: tags ?? category,
                    url: pageUrl ?? "",
                    imageUrl: imageUrl ?? ""
                ));
            }

            return results;
        }
    }
}
////https://pixabay.com/api/?key={ KEY }&q=yellow+flowers&image_type=photo
