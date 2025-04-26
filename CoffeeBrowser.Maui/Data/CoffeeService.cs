

using System.Net.Http.Json;

namespace CoffeeBrowser.Maui.Data
{
    
    internal class CoffeeService : ICoffeeService
    {
        private readonly HttpClient _httpClent = new();
        public async Task<IEnumerable<Coffee>?> LoadCofeesAsync()
        {
            //var coffees = await _httpClent.GetFromJsonAsync<IEnumerable<Coffee>>(
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
