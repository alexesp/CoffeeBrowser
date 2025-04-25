using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeBrowser.Maui.Data
{

    internal class CoffeeService : ICoffeeService
    {
        public async Task<IEnumerable<Coffee>> LoadCofeesAsync()
        {
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
