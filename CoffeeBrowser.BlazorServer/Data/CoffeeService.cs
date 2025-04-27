using CoffeeBrowser.Library.Data;

using System.Net.Http.Json;

namespace CoffeeBrowser.BlazorServer.Data
{
    
    public class CoffeeService : ICoffeeService
    {
        //private readonly HttpClient _httpClent = new();
        private readonly IHttpClientFactory _factory;

        public CoffeeService(IHttpClientFactory factory)
        {
            _factory = factory;
        }
        public async Task<IEnumerable<Coffee>?> LoadCofeesAsync()
        {

           using var httpClient = _factory.CreateClient();
            //var coffees = await httpClent.GetFromJsonAsync<IEnumerable<Coffee>>(
            //    "");
            var coffees = new[]
            {
                new Coffee("Cappuccino", "Coffee with milk foam"),
                new Coffee("Doppio", "Double espresso")
            };
            await Task.Delay(50);
            return coffees;
        }
    }
}
