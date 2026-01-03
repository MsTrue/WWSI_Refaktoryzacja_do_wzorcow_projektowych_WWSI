using RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.Strategy.Strategy;
namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.ZRozwiazania.StrategyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
          var pexelsKey = "6Hv8UTxtBCcG5E9AP0M4fVO5ovUUml3jJaiJEtWasroNByGhjFCg07XJ";
            var pixabayKey = "54029280-f54f729d3f1301363dda271c6";

            using var http = new HttpClient();

            while (true)
            {
                Console.WriteLine("\nChoose provider:");
                Console.WriteLine("1) Pexels");
                Console.WriteLine("2) Pixabay");
                Console.WriteLine("0) Exit");
                Console.Write("Your choice: ");
                var choice = Console.ReadLine();

                if (choice == "0") break;

                IPhotoStrategy strategy;
                try
                {
                    strategy = choice switch
                    {
                        "1" => new PexelsStrategy(http, pixabayKey),
                        "2" => new PixabayStrategy(http, pixabayKey),
                        _ => throw new InvalidOperationException("Un...")
                    };
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                // nature, car
                Console.Write("Enter category/keyword: ");
                var category = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(category))
                {
                    Console.WriteLine("Category required.");
                    continue;
                }
                Console.Write("How many results?");
                var perPageText = Console.ReadLine();
                var perPage = int.TryParse(perPageText, out var n) && n > 0 ? n : 5;

                var client = new PhotoClient(strategy);

                try
                {
                    var results = await client.SearchAsync(category, perPage);

                    Console.WriteLine($"Found: {results.Count}");
                    for (int i = 0; i < results.Count; i++)
                    {
                        var r = results[i];
                        Console.WriteLine($"{i + 1}.{r.Title}");
                        Console.WriteLine($"Page:  {r.url}");
                        Console.WriteLine($"Image: {r.imageUrl}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Done..");
        }
        }

      
    }


//https://pixabay.com/api/?key={ KEY }&q=yellow+flowers&image_type=photo